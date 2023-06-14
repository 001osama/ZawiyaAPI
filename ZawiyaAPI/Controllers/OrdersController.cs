using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using ZawiyaAPI.Models;
using ZawiyaAPI.Models.Dto;
using ZawiyaAPI.Repository.IRepository;

namespace ZawiyaAPI.Controllers
{
    [Route("api/orders")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        protected APIResponse _response;
        private readonly IProductRepository _dbProduct;
        private readonly IShoppingCartRepository _dbShoppingCart;
        private readonly IOrderRepository _dbOrder;
        private readonly IOrderDetailRepository _dbOrderDetail;
        private readonly IMapper _mapper;

        public OrdersController(APIResponse response,IOrderRepository dbOrder, IOrderDetailRepository dbOrderDetail, IProductRepository dbProduct, IShoppingCartRepository dbShoppingCart, IMapper mapper)
        {
            this._response = new();
            _dbShoppingCart = dbShoppingCart;
            _dbProduct = dbProduct;
            _dbOrder = dbOrder;
            _dbOrderDetail = dbOrderDetail;
            _mapper = mapper;
        }

        [HttpGet("{productId:int}", Name = "GetBid")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<ActionResult<APIResponse>> GetCustomerOrder(int buyerId)
        {
            try
            {
                if (buyerId == 0)
                {
                    _response.StatusCode = HttpStatusCode.BadRequest;
                    _response.IsSuccess = false;
                    return BadRequest(_response);
                }
                var orderList = await _dbOrder.GetAllAsync(u => u.BuyerId== buyerId);
                if (orderList == null || !orderList.Any())
                {
                    _response.StatusCode = HttpStatusCode.NotFound;
                    _response.IsSuccess = false;
                    _response.ErrorMessage.Add("There are no Order of this user");
                    return NotFound(_response);
                }
                _response.Result = _mapper.Map<List<OrderDTO>>(orderList);
                _response.StatusCode = HttpStatusCode.OK;
                return Ok(_response);
            }

            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessage = new List<string>() { ex.ToString() };
            }
            return _response;
        }



        //[HttpGet]
        //[ProducesResponseType(StatusCodes.Status200OK)]
        //[ProducesResponseType(StatusCodes.Status403Forbidden)]
        //[ProducesResponseType(StatusCodes.Status401Unauthorized)]

        //public async Task<ActionResult<APIResponse>> GetOrders()
        //{
        //    try
        //    {
        //        IEnumerable<Order> orderList;
        //        orderList = await _db
        //    }
        //}



    }
}
