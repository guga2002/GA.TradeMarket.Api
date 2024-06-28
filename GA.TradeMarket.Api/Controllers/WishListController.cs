using GA.TradeMarket.Application.Interfaces;
using GA.TradeMarket.Application.Models.RequestModels;
using GA.TradeMarket.Application.Models;
using GA.TradeMarket.Application.StaticFIles;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Caching.Memory;

namespace GA.TradeMarket.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WishListController : ControllerBase
    {

        private readonly IWishListService ser;
        private readonly ILogger<WishListController> logger;
        private readonly IMemoryCache cash;
        public WishListController(IWishListService ser, ILogger<WishListController> logger,IMemoryCache cash)
        {
            this.ser = ser; 
            this.logger = logger;
            this.cash = cash;
        }

        /// <summary>
        /// Add item to wishList
        /// </summary>
        /// <remarks>
        /// allow  for **Customer**
        /// </remarks>
        [HttpPost]
        [Authorize(Roles = "customer")]
        public async Task<ActionResult> AddAsync([FromBody] WishListModelIn item)
        {
            if (ModelState.IsValid)
            {
                await ser.AddAsync(item);
                return Ok(item);
            }
            return BadRequest(ModelState);
        }

        /// <summary>
        /// Removing item fron wishlist 
        /// </summary>
        /// <remarks>
        /// allow  for **Customer**
        /// </remarks>
        [HttpDelete]
        [Authorize(Roles = "customer")]
        [Route("{id:long}")]
        public async Task<ActionResult> DeleteAsync([FromRoute] long id)
        {
            await ser.DeleteAsync(id);
            return Ok(id);
        }

        /// <summary>
        /// Get all wishlist for  current customer
        /// </summary>
        /// <remarks>
        /// allow  for **Customer**
        /// </remarks>
        [HttpGet]
        [Authorize(Roles = "customer")]
        public async Task<ActionResult<IEnumerable<WishListModel>>> GetAllWithDetailsAsync()
        {
            if (User is { Identity.IsAuthenticated: true, Identity.Name: not null, Identity: not null })
            {
                var wishlists = await ser.GetAllWithDetailsAsync(User.Identity.Name);
                if (wishlists.Any())
                {
                    return Ok(wishlists);
                }
                return NotFound(ErrorKeys.NotFound);
            }
            return Unauthorized(ErrorKeys.NoCustommer);
        }

        /// <summary>
        /// get Wishlist by identitficator 
        /// </summary>
        /// <remarks>
        ///allow  for **Customer**
        /// </remarks>
        [HttpGet]
        [Route("{Id:long}")]
        [Authorize(Roles = "operator,manager")]
        public async Task<ActionResult<WishListModel>> GetByIdAsync([FromRoute] long Id)
        {
            var chashedkey = $"Getbyid{Id}";
            if (cash.TryGetValue(chashedkey, out WishListModel? wish))
            {
                if (wish is not null)
                {
                    return wish;
                }
            }
            var res = await ser.GetByIdAsync(Id);
            if (res is not null)
            {
                cash.Set(chashedkey, res, TimeSpan.FromMinutes(10));
                return Ok(res);
            }
            return NotFound(ErrorKeys.NotFound);
        }

        /// <summary>
        /// Update wishList
        /// </summary>
        /// <remarks>
        /// allow  for **Customer**
        /// </remarks>
        [HttpPut]
        [Authorize(Roles = "customer")]
        public async Task<ActionResult> UpdateAsync([FromBody] WishListModelIn item)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            await ser.UpdateAsync(item);
            return Ok(item);
        }
    }
}
