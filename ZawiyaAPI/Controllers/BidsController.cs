using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using ZawiyaAPI.Models.Dto;
using ZawiyaAPI.Models;
using AutoMapper;
using ZawiyaAPI.Repository.IRepository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Hosting;
using System.Security.Claims;
using Microsoft.AspNetCore.SignalR;
using ZawiyaAPI.Hub;

namespace ZawiyaAPI.Controllers
{
    [Route("api/bids")]
    [ApiController]
    public class BidsController : ControllerBase
    {
        protected APIResponse _response;
        private readonly IBidRepository _dbBid;
        private readonly IMapper _mapper;
        private readonly IUserRepository _dbUser;
        private IHubContext<BidHub, IBidHubClient> _bidHub;



        public BidsController(IBidRepository dbBid, IMapper mapper, IUserRepository dbUser, IHubContext<BidHub, IBidHubClient> bidHub)
        {
            this._response = new();
            _dbBid = dbBid;
            _bidHub = bidHub;
            _mapper = mapper;
            _dbUser = dbUser;
        }


        [HttpGet]
        //[Authorize(Roles = "admin")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]

        public async Task<ActionResult<APIResponse>> GetBids()
        {
            try
            {
                IEnumerable<Bid> bidList;
                bidList = await _dbBid.GetAllAsync();
                _response.Result = _mapper.Map<List<BidDTO>>(bidList);
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

        [HttpGet("{productId:int}", Name = "GetItemBids")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<ActionResult<APIResponse>> GetItemBids(int productId)
        {
            try
            {
                if (productId == 0)
                {
                    _response.StatusCode = HttpStatusCode.BadRequest;
                    _response.IsSuccess = false;
                    return BadRequest(_response);
                }
                var bidList = await _dbBid.GetAllAsync(u => u.ProductId == productId);
                if (bidList == null || !bidList.Any())
                {
                    _response.StatusCode = HttpStatusCode.NotFound;
                    _response.IsSuccess = false;
                    _response.ErrorMessage.Add("There are no bids on this product");
                    return NotFound(_response);
                }
                _response.Result = _mapper.Map<List<BidDTO>>(bidList);
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



        [HttpPost]
        //[Authorize(Roles = "buyer")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<ActionResult<APIResponse>> CreateBid(int productId, int amount)
        {
            try
            {
                if (productId == 0 || amount == 0)
                {
                    _response.StatusCode = HttpStatusCode.BadRequest;
                    _response.IsSuccess = false;
                    return BadRequest(_response);
                }
                var highestBid = await _dbBid.GetHighestBid(productId);

                if ( highestBid != null && highestBid.Amount >= amount)
                {
                    ModelState.AddModelError("ErrorMessage", "Same amount of bid already exist. Make Higher Bid");
                    return BadRequest(ModelState);
                }

                //var claimsIdentity = (ClaimsIdentity)User.Identity;
                //var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
                //var roleClaim = claimsIdentity.FindFirst(ClaimTypes.Role);

                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

                if( userId == null)
                {
                    _response.StatusCode = HttpStatusCode.Unauthorized;
                    _response.IsSuccess = false;
                    return Unauthorized(_response);
                }

                var role = User.FindFirstValue(ClaimTypes.Role);
                var buyerId = await _dbUser.GetRoleIdAsync(userId, role);

                if (buyerId == 0)
                {
                    ModelState.AddModelError("ErrorMessage", "Buyer Doesnot Exist");
                    return BadRequest(ModelState);
                }
                Bid bid = new Bid()
                {
                    Amount = amount,
                    BidTime = DateTime.Now,
                    IsCurrentBid = true,
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    BuyerId = buyerId,
                    ProductId = productId
                };
                await _dbBid.CreateAsync(bid);
                var bidDTO = _mapper.Map<BidDTO>(bid);
                _response.Result = bidDTO;
                _response.StatusCode = HttpStatusCode.Created;
                await _bidHub.Clients.All.UpdateBidList("BidUpdated",productId, bidDTO);
                return _response;
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessage = new List<string>() { ex.ToString() };
            }
            return _response;
        }
    }
}
