using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Stripe;
using Stripe.Checkout;
using Stripe.Issuing;
using System.Net;
using System.Security.Claims;
using ZawiyaAPI.Models;
using ZawiyaAPI.Models.Dto;
using ZawiyaAPI.Repository.IRepository;

namespace ZawiyaAPI.Controllers
{
    [Route("api/cart")]
    [ApiController]
    public class ShoppingCartController : ControllerBase
    {
        protected APIResponse _response;
        private readonly IShoppingCartRepository _dbShoppingCart;
        private readonly IOrderRepository _dbOrder;
        private readonly IOrderDetailRepository _dbOrderDetail;
        private readonly ICartItemRepository _dbCartItem;
        private readonly IUserRepository _dbUser;
        private readonly IMapper _mapper;
        private readonly IBidRepository _dbBid;

        public ShoppingCartController(IShoppingCartRepository dbShoppingCart, IOrderDetailRepository dbOrderDetail, IOrderRepository dbOrder, IUserRepository dbUser, IBidRepository dbBid, ICartItemRepository dbCartItem, IMapper mapper)
        {
            this._response = new();
            _dbShoppingCart = dbShoppingCart;
            _dbUser = dbUser;
            _mapper = mapper;
            _dbBid = dbBid;
            _dbCartItem = dbCartItem;
            _dbOrder = dbOrder;
            _dbOrderDetail = dbOrderDetail;
        }

        [HttpPost]
        //[Authorize(Roles = "admin, buyer")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<ActionResult<APIResponse>> AddToCart(int productId)
        {
            try
            {

                var highestBid = await _dbBid.GetHighestBid(productId);
                var user = await _dbUser.GetUser(highestBid.BuyerId);           
                var shoppingCart = await _dbShoppingCart.GetAsync(x => x.ApplicationUserId == user.Id, true, "CartItems");


                if (shoppingCart == null)
                {
                    var newShoppingCart = new ShoppingCart()
                    {
                        ApplicationUserId = user.Id,
                        TotalPrice = 0,
                        CreatedDate = DateTime.Now,
                        UpdatedDate = DateTime.Now
                    };

                    await _dbShoppingCart.CreateAsync(newShoppingCart);
                    shoppingCart = newShoppingCart;
                }

                var cartItem = new CartItem()
                {
                    ProductId = productId,
                    Price = highestBid.Amount,
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    CartId = shoppingCart.Id
                };


                shoppingCart.CartItems.Add(cartItem);
                await _dbCartItem.CreateAsync(cartItem);

                _response.Result = _mapper.Map<ShoppingCartDTO>(shoppingCart);
                _response.StatusCode = HttpStatusCode.Created;
                return _response;
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessage = new List<string>() { ex.ToString() };
            }
            return _response;
        }



        [HttpPost("Checkout")]
        public async  Task<ActionResult> Checkout()
        {
            try
            {
                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                var shoppingCart = _dbShoppingCart.GetAsync(x => x.ApplicationUserId == userId, true, "CartItems");
                var buyerId = _dbUser.GetRoleIdAsync(userId, "buyer");

                var order = new Order()
                {
                    OrderDate = DateTime.Now,
                    TotalAmount = 0,
                    Status = SD.StatusPending,
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    BuyerId = buyerId.Result
                };

                foreach (var item in shoppingCart.Result.CartItems)
                {
                    order.TotalAmount += item.Price;
                };
                await _dbOrder.CreateAsync(order);

                //stripe settings
                var domain = "https://localhost:44306/";
                var options = new SessionCreateOptions
                {
                    LineItems = new List<SessionLineItemOptions>(),
                    Mode = "payment",
                    SuccessUrl = domain + $"customer/cart/OrderConfirmation?id={order.OrderId}",
                    CancelUrl = domain + $"customer/cart/index",
                };
                foreach (var item in shoppingCart.Result.CartItems)
                {
                    var sessionLineItem = new SessionLineItemOptions
                    {
                        PriceData = new SessionLineItemPriceDataOptions
                        {
                            UnitAmount = (int)(item.Price * 100),
                            Currency = "usd",
                            ProductData = new SessionLineItemPriceDataProductDataOptions
                            {
                                Name = item.Product.Name,
                            },
                        },
                        Quantity = 1,
                    };
                    options.LineItems.Add(sessionLineItem);
                };
            
                var service = new SessionService();
                Session session = service.Create(options);

                await _dbOrder.UpdateStripePaymentId(order.OrderId,session.Id, session.PaymentIntentId);

                Response.Headers.Add("Location", session.Url);
                return new StatusCodeResult(303);
            }
            catch (Exception ex)
            {
                return new StatusCodeResult(StatusCodes.Status400BadRequest);
            }
        }

        [HttpGet("OrderConfirmation")]
        public async Task<ActionResult<APIResponse>> OrderConfirmation(int orderId)
        {
            try
            {
                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                var order = await _dbOrder.GetAsync(x => x.OrderId == orderId);
                if (order.Status != SD.StatusCompleted)
                {
                    var service = new SessionService();
                    Session session = service.Get(order.SessionId);
                    //check stripe status
                    if (session.PaymentStatus.ToLower() == "paid")
                    {
                        await _dbOrder.UpdateStatus(orderId, SD.StatusCompleted);
                    }
                }
                var shoppingCart = _dbShoppingCart.GetAsync(x=> x.ApplicationUserId == userId, includeProperties:"CartItems");
                foreach (var cart in shoppingCart.Result.CartItems)
                {
                    OrderDetail orderDetail = new()
                    {
                        ProductId = cart.ProductId,
                        OrderId = order.OrderId,
                        Price = cart.Price,
                        CreatedDate = DateTime.Now,
                        UpdatedDate = DateTime.Now
                    };
                    await _dbOrderDetail.CreateAsync(orderDetail);
                }
                await _dbShoppingCart.RemoveAsync(shoppingCart.Result);

                _response.Result = _mapper.Map<OrderDTO>(order);
                _response.StatusCode = HttpStatusCode.OK;
                return Ok(_response);
            }
            catch(Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessage = new List<string>() { ex.ToString() };
            }
            return _response;
        }
    }
}

