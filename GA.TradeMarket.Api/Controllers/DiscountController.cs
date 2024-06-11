using GA.TradeMarket.Application.Interfaces;
using GA.TradeMarket.Application.Models;
using GA.TradeMarket.Application.Models.RequestModels;
using GA.TradeMarket.Application.StaticFIles;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace GA.TradeMarket.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public sealed class DiscountController : ControllerBase
    {
        private readonly IDiscountService ser;
        private readonly ILogger<DiscountController> logger;
        private readonly IMemoryCache memoryCache;

        public DiscountController(ILogger<DiscountController> log, IDiscountService ser, IMemoryCache cash)
        {
            this.ser = ser;
            this.logger = log;
            this.memoryCache = cash;
        }

        /// <summary>
        /// Get my loyalty program (current customer who is signed in).
        /// </summary>
        /// <remarks>
        /// allow  for user with role 'customer'
        /// </remarks>
        /// <returns>Returns the loyalty program of the signed-in customer.</returns>
        [HttpGet]
        [Route(nameof(MyLoyalityProgram))]
        [Authorize(Roles = "customer")]
        public async Task<ActionResult<BonusProgramModel>> MyLoyalityProgram()
        {
            try
            {
                if (User.Identity?.Name is not null)
                {
                    var res = await ser.GetMyLoyalityProgram(User.Identity.Name);
                    return Ok(res);
                }
                return Unauthorized(ErrorKeys.General);
            }
            catch (Exception exp)
            {
                return BadRequest(exp.Message);
            }
        }

        /// <summary>
        /// Get details about the loyalty program..
        /// </summary>
        /// <remarks>
        /// allow  for user with role 'manager',,'operator' , **cashing is enable**
        /// </remarks>
        /// <returns>Returns a list of bonus program models.</returns>
        [HttpGet]
        [Route("bonusprogram")]
        [Authorize(Roles = "manager,operator")]
        public async Task<ActionResult<IEnumerable<BonusProgramModel>>> GetAllWithDetailsAsync()
        {
            try
            {
                var cachedKey = "GetAllLoyalityProgram";
                if (memoryCache.TryGetValue(cachedKey, out IEnumerable<BonusProgramModel>? bonus))
                {
                    if (bonus is not null)
                    {
                        return Ok(bonus);
                    }
                }
                var res = await ser.GetAllWithDetailsAsync();
                if (!res.Any())
                {
                    return NotFound(ErrorKeys.NotFound);
                }
                memoryCache.Set(cachedKey, res, TimeSpan.FromMinutes(10));
                return Ok(res);
            }
            catch (Exception exp)
            {
                logger.LogCritical($"Error occurred while sending request: {exp.Message}");
                return BadRequest(exp.Message);
            }
        }

        /// <summary>
        /// Get details about the loyalty program by ID.
        /// </summary>
        /// <remarks>
        /// allow  for user with role 'manager','operator', **cashing is enable**
        /// </remarks>
        /// <param name="Id">The ID of the loyalty program.</param>
        /// <returns>Returns the bonus program model for the specified ID.</returns>
        [HttpGet]
        [Route("bonusprogram/{Id:long}")]
        [Authorize(Roles = "manager,operator")]
        public async Task<ActionResult<BonusProgramModel>> GetByIdAsync([FromRoute] long Id)
        {
            try
            {
                var cachedKey = $"GetLoyalityPrograms{Id}";
                if (memoryCache.TryGetValue(cachedKey, out BonusProgramModel? mod))
                {
                    if (mod is not null)
                    {
                        return Ok(mod);
                    }
                }
                var res = await ser.GetByIdAsync(Id);
                if (res is null)
                {
                    return NotFound(ErrorKeys.NotFound);
                }
                memoryCache.Set(cachedKey, res, TimeSpan.FromMinutes(10));
                return Ok(res);
            }
            catch (Exception exp)
            {
                logger.LogCritical($"Error while fetching data with id: {exp.Message}");
                return BadRequest(exp.Message);
            }
        }

        /// <summary>
        /// Add a new loyalty program account in the database.
        /// </summary>
        /// <remarks>
        /// allow  for user with role 'manager','operator'
        /// </remarks>
        /// <param name="item">The bonus program model to add.</param>
        /// <returns>Returns the added bonus program model.</returns>
        [HttpPost]
        [Route("bonusprogram")]
        [Authorize(Roles = "manager,operator")]
        public async Task<ActionResult> AddAsync([FromBody] BonusProgramModelIn item)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await ser.AddAsync(item);
                    return Ok(item);
                }
                return BadRequest(ErrorKeys.UnsuccesfullInsert);
            }
            catch (Exception exp)
            {
                logger.LogCritical($"Error while trying to add request: {exp.Message}");
                return BadRequest(exp.Message);
            }
        }

        /// <summary>
        /// Delete a loyalty program account from the database. 
        /// </summary>
        /// <remarks>
        /// allow  for user with role 'manager'
        /// </remarks>
        /// <param name="item">The ID of the loyalty program to delete.</param>
        /// <returns>Returns the ID of the deleted loyalty program.</returns>
        [HttpDelete]
        [Route("bonusprogram/{item:long}")]
        [Authorize(Roles = "manager")]
        public async Task<ActionResult> DeleteAsync([FromRoute] long item)
        {
            try
            {
                await ser.DeleteAsync(item);
                return Ok(item);
            }
            catch (Exception exp)
            {
                logger.LogCritical($"Error while deleting loyalty program with ID {item}: {exp.Message}");
                return BadRequest(exp.Message);
            }
        }

        /// <summary>
        /// Update loyalty program details.
        /// </summary>
        /// <remarks>
        /// allow  for user with role 'manager','operator'
        /// </remarks>
        /// <param name="item">The bonus program model to update.</param>
        /// <returns>Returns the updated bonus program model.</returns>
        [HttpPut]
        [Route("bonusprogram")]
        [Authorize(Roles = "manager,operator")]
        public async Task<ActionResult> UpdateAsync([FromBody] BonusProgramModelIn item)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await ser.UpdateAsync(item);
                    return Ok(item);
                }
                return BadRequest(ErrorKeys.UnsucessfullUpdate);
            }
            catch (Exception exp)
            {
                logger.LogCritical($"Error while trying to update: {exp.Message}");
                return BadRequest(exp.Message);
            }
        }

        /// <summary>
        /// Update discount coupon details. 
        /// </summary>
        /// <remarks>
        /// allow  for user with role 'operator','manager'
        /// </remarks>
        /// <param name="mod">The coupon model to update.</param>
        /// <returns>Returns the updated coupon model.</returns>
        [HttpPut]
        [Route("coupon")]
        [Authorize(Roles = "manager,operator")]
        public async Task<ActionResult> UpdateCouponAsync([FromBody] CouponModelIn mod)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await ser.UpdateCouponAsync(mod);
                    return Ok(mod);
                }
                return BadRequest(ErrorKeys.UnsucessfullUpdate);
            }
            catch (Exception exp)
            {
                logger.LogError($"Error while trying to edit coupon details: {exp.Message}");
                return BadRequest(exp.Message);
            }
        }

        /// <summary>
        /// Delete a discount coupon from the database.
        /// </summary>
        /// <remarks>
        /// allow  for user with role 'maanager','operator'
        /// </remarks>
        /// <param name="Id">The ID of the coupon to delete.</param>
        /// <returns>Returns the ID of the deleted coupon.</returns>
        [HttpDelete]
        [Route("coupon/{Id:long}")]
        [Authorize(Roles = "manager,operator")]
        public async Task<ActionResult> RemoveCouponAsync([FromRoute] long Id)
        {
            try
            {
                await ser.RemoveCouponAsync(Id);
                return Ok(Id);
            }
            catch (Exception exp)
            {
                logger.LogCritical($"Error while trying to remove coupon from DB: {exp.Message}");
                return BadRequest(exp.Message);
            }
        }

        /// <summary>
        /// Add a new discount coupon to the database.
        /// </summary>
        /// <remarks>
        /// allow  for user with role 'manager','operator'
        /// </remarks>
        /// <param name="mod">The coupon model to add.</param>
        /// <returns>Returns the added coupon model.</returns>
        [HttpPost]
        [Route("coupon")]
        [Authorize(Roles = "manager,operator")]
        public async Task<ActionResult> AddCouponAsync([FromBody] CouponModelIn mod)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await ser.AddCouponAsync(mod);
                    return Ok(mod);
                }
                return BadRequest(ErrorKeys.NoCoupon);
            }
            catch (Exception exp)
            {
                logger.LogTrace($"Error while trying to add new discount coupon: {exp.Message}");
                return BadRequest(exp.Message);
            }
        }

        /// <summary>
        /// Get all available discount coupons.
        /// </summary>
        /// <remarks>
        /// allow  for user with role 'manager','operator'
        /// </remarks>
        /// <returns>Returns a list of coupon models.</returns>
        [HttpGet]
        [Route("coupon")]
        [Authorize(Roles = "manager,operator")]
        public async Task<ActionResult<IEnumerable<CouponModel>>> GetAllCouponAsync()
        {
            try
            {
                var cachedKey = "GetAllDiscountCoupons";
                if (memoryCache.TryGetValue(cachedKey, out IEnumerable<CouponModel>? coupon))
                {
                    if (coupon is not null)
                    {
                        return Ok(coupon);
                    }
                }
                var res = await ser.GetAllCouponAsync();
                if (res.Any())
                {
                    memoryCache.Set(cachedKey, res, TimeSpan.FromMinutes(10));
                    return Ok(res);
                }
                return NotFound(ErrorKeys.NotFound);
            }
            catch (Exception exp)
            {
                logger.LogCritical($"Error occurred while trying to get data from coupon: {exp.Message}");
                return BadRequest(exp.Message);
            }
        }
    }
}
