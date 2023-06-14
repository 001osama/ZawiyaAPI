using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Security.Claims;
using ZawiyaAPI.Models;
using ZawiyaAPI.Models.Dto;
using ZawiyaAPI.Repository.IRepository;

namespace ZawiyaAPI.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        protected APIResponse _response;
        private readonly IProductRepository _dbProduct;
        private readonly IUserRepository _dbUser;
        private readonly IMapper _mapper;
        private readonly IWebHostEnvironment _hostEnvironment;

        public ProductsController(IProductRepository dbProduct, IUserRepository dbUser, IMapper mapper, IWebHostEnvironment hostEnvironment)
        {
            this._response = new();
            _dbProduct = dbProduct;
            _dbUser = dbUser;
            _mapper = mapper;
            _hostEnvironment = hostEnvironment;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]

        public async Task<ActionResult<APIResponse>> GetProducts([FromQuery] string? search,
            int pageSize = 8, int pageNumber = 1)
        {
            try
            {
                IEnumerable<Product> productList;
                productList = await _dbProduct.GetAllAsync(pageSize: pageSize, pageNumber: pageNumber);

                if (!string.IsNullOrEmpty(search))
                {
                    productList = productList.Where(u => u.Name.ToLower().Contains(search.ToLower()));
                }
                _response.Result = _mapper.Map<List<ProductDTO>>(productList);
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


        //[Authorize(Roles = "seller")]
        [HttpGet("{id:int}", Name = "GetProduct")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<ActionResult<APIResponse>> GetProduct(int id)
        {
            try
            {
                if (id == 0)
                {
                    _response.StatusCode = HttpStatusCode.BadRequest;
                    _response.IsSuccess = false;
                    return BadRequest(_response);
                }
                var product = await _dbProduct.GetAsync(u => u.ProductId == id);
                if (product == null)
                {
                    _response.StatusCode = HttpStatusCode.NotFound;
                    _response.IsSuccess = false;
                    return NotFound(_response);
                }

                _response.Result = _mapper.Map<ProductDTO>(product);
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
        //[Authorize(Roles = "admin, seller")]
        [Authorize(Roles = "seller")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]

        public async Task<ActionResult<APIResponse>> CreateProduct([FromForm] ProductCreateDTO createDTO)
        {
            try
            {
                if (await _dbProduct.GetAsync(u => u.Name == createDTO.Name) != null)
                {
                    ModelState.AddModelError("ErrorMessage", "Product Already Exist");
                    return BadRequest(ModelState);
                }

                if (createDTO == null)
                {
                    return BadRequest(createDTO);
                }
                //var claimsIdentity = (ClaimsIdentity)User.Identity;
                //var userId = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier).Value;
                //var role = claimsIdentity.RoleClaimType;

                var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                var role = this.User.FindFirstValue(ClaimTypes.Role);
                var sellerId = await _dbUser.GetRoleIdAsync(userId, role);
                
                if (sellerId == 0) 
                {
                    ModelState.AddModelError("ErrorMessage", "Seller Doesnot Exist");
                    return BadRequest(ModelState);
                }

                if (createDTO.ImageFile == null)
                {
                    ModelState.AddModelError("ErrorMessage", "Product Image is required");
                    return BadRequest(ModelState);
                }

                string wwwRootPath = _hostEnvironment.WebRootPath;

                string fileName = Guid.NewGuid().ToString();
                var uploads = Path.Combine(wwwRootPath, @"images\products");
                var extension = Path.GetExtension(createDTO.ImageFile.FileName);

                using (var fileStreams = new FileStream(Path.Combine(uploads, fileName + extension), FileMode.Create))
                {
                    await createDTO.ImageFile.CopyToAsync(fileStreams);
                }

                Product product = _mapper.Map<Product>(createDTO);
                product.CreatedDate = DateTime.Now;
                product.SellerId = sellerId;
                product.ImageUrl = @"\images\products\" + fileName + extension;

                await _dbProduct.CreateAsync(product);
                _response.Result = _mapper.Map<ProductDTO>(product);
                _response.StatusCode = HttpStatusCode.Created;
                return _response;
                //return CreatedAtRoute("Product", new { id = product.ProductId }, _response);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessage = new List<string>() { ex.ToString() };
            }
            return _response;
        }

        [HttpDelete("{id:int}")]
        //[Authorize(Roles = "admin")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<ActionResult<APIResponse>> DeleteProduct(int id)
        {
            try
            {
                if (id == 0)
                {
                    return BadRequest();
                }
                var product = await _dbProduct.GetAsync(u => u.ProductId == id);
                if (product == null)
                {
                    return NotFound();
                }
                await _dbProduct.RemoveAsync(product);
                _response.StatusCode = HttpStatusCode.NoContent;
                _response.IsSuccess = true;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessage = new List<string>() { ex.ToString() };
            }
            return _response;

        }

        //[Authorize(Roles = "admin")]
        [HttpPut("{id:int}", Name = "UpdateProduct")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]

        public async Task<ActionResult<APIResponse>> UpdateProduct(int id, [FromForm] ProductUpdateDTO updateDTO)
        {
            try
            {
                if (id == 0 || id != updateDTO.ProductId)
                {
                    return BadRequest();
                }
                
                //var claimsIdentity = (ClaimsIdentity)User.Identity;
                //var userId = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier).Value;
                //var role = claimsIdentity.RoleClaimType;

                var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                var role = this.User.FindFirstValue(ClaimTypes.Role);

                var sellerId = await _dbUser.GetRoleIdAsync(userId, role);
                if (sellerId == 0)
                {
                    ModelState.AddModelError("ErrorMessage", "Seller Doesnot Exist");
                    return BadRequest(ModelState);
                }
                string wwwRootPath = _hostEnvironment.WebRootPath;

                var oldProduct = await _dbProduct.GetAsync(u => u.ProductId == id);
                if (updateDTO.ImageFile != null)
                {

                    var oldImagePath = Path.Combine(wwwRootPath, oldProduct.ImageUrl.TrimStart('\\'));
                    if (System.IO.File.Exists(oldImagePath))
                    {
                        System.IO.File.Delete(oldImagePath);
                    }

                    string fileName = Guid.NewGuid().ToString();
                    var uploads = Path.Combine(wwwRootPath, @"images\products");
                    var extension = Path.GetExtension(updateDTO.ImageFile.FileName);

                    using (var fileStreams = new FileStream(Path.Combine(uploads, fileName + extension), FileMode.Create))
                    {
                        await updateDTO.ImageFile.CopyToAsync(fileStreams);
                    }
                    Product product = _mapper.Map<Product>(updateDTO);
                    product.UpdatedDate = DateTime.Now;
                    product.SellerId = sellerId;
                    product.ImageUrl = @"\images\products\" + fileName + extension;

                    await _dbProduct.UpdateAsync(product);
                    _response.StatusCode = HttpStatusCode.NoContent;
                    _response.IsSuccess = true;
                    return Ok(_response);
                }
                else
                {
                    Product product = _mapper.Map<Product>(updateDTO);
                    product.UpdatedDate = DateTime.Now;
                    product.SellerId = sellerId;
                    product.ImageUrl = oldProduct.ImageUrl;

                    await _dbProduct.UpdateAsync(product);
                    _response.StatusCode = HttpStatusCode.NoContent;
                    _response.IsSuccess = true;
                    return Ok(_response);
                }

                
            }

            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessage = new List<string>() { ex.ToString() };
            }
            return _response;
        }

        [HttpPatch("{id:int}", Name = "UpdatePartialProduct")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<IActionResult> UpdatePartialProduct(int id, JsonPatchDocument<ProductUpdateDTO> patchDTO)
        {
            if (patchDTO == null || id == 0)
            {
                return BadRequest();
            }
            var product = await _dbProduct.GetAsync(u => u.ProductId == id, tracked: false);

            if (product == null)
            {
                return BadRequest();
            }

            ProductUpdateDTO productDTO = _mapper.Map<ProductUpdateDTO>(product);


            patchDTO.ApplyTo(productDTO, ModelState);
            Product model = _mapper.Map<Product>(productDTO);

            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var role = this.User.FindFirstValue(ClaimTypes.Role);

            var sellerId = await _dbUser.GetRoleIdAsync(userId, role);
            if (sellerId == 0)
            {
                ModelState.AddModelError("ErrorMessage", "Seller Doesnot Exist");
                return BadRequest(ModelState);
            }
            model.SellerId = sellerId;

            await _dbProduct.UpdateAsync(model);
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return NoContent();
        }
    }
}