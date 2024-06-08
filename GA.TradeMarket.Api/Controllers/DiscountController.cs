using GA.TradeMarket.Application.Interfaces;
using GA.TradeMarket.Application.Models;
using GA.TradeMarket.Application.Models.RequestModels;
using GA.TradeMarket.Application.StaticFIles;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GA.TradeMarket.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public sealed class DiscountController : ControllerBase
    {
        private readonly IDiscountService ser;
        private readonly ILogger<DiscountController> logger;

        public DiscountController(ILogger<DiscountController> log, IDiscountService ser)
        {
            this.ser = ser;
            this.logger = log;
        }

        /// <summary>
        /// get my loyality program(current customer who is signed in,, allow only for customer
        /// </summary>
        [HttpGet]
        [Route(nameof(MyLoyalityProgram))]
        [Authorize(Roles ="customer")]
        public async Task<ActionResult<BonusProgramModel>> MyLoyalityProgram()
        {
            try
            {
                if(User.Identity?.Name is not null)
                {
                   var res=await ser.GetMyLoyalityProgram(User.Identity.Name);
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
        /// Get details about Loyality program, allowed access for manager , operator
        /// </summary>
        [HttpGet]
        [Route("bonusprogram")]
        [Authorize(Roles ="manager,operator")]
        public async Task<ActionResult<IEnumerable<BonusProgramModel>>> GetAllWithDetailsAsync()
        {
            try
            {
                var res= await ser.GetAllWithDetailsAsync();
                if(!res.Any())
                {
                    return NotFound(ErrorKeys.NotFound);
                }
                return Ok(res);
            }
            catch (Exception exp)
            {
                logger.LogCritical($"Error ocured while sending request:{exp.Message}");
                return BadRequest(exp.Message);
            }
        }

        /// <summary>
        /// Get details about Loyality program by Id, allowed operator,manager
        /// </summary>
        [HttpGet]
        [Route("bonusprogram/{Id:long}")]
        [Authorize(Roles ="manager,operator")]
        public async Task<ActionResult<IEnumerable<CouponModel>>> GetByIdAsync([FromRoute]long Id)
        {
            try
            {
                var res = await ser.GetByIdAsync(Id);
                if (res is null)
                {
                    return NotFound(ErrorKeys.NotFound);
                }
                return Ok(res);
            }
            catch (Exception exp)
            {
                logger.LogCritical($"Error while fetching data with id:{exp.Message}");
                return BadRequest(exp.Message);
            }
        }

        /// <summary>
        ///add new Loiality program account in DB- allowed manager ,operator
        /// </summary>
        [HttpPost]
        [Route("bonusprogram")]
        [Authorize(Roles ="manager,operator")]
        public async Task<ActionResult> AddAsync([FromBody]BonusProgramModelIn item)
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
                logger.LogCritical($"error while trying, add  request:{exp.Message}");
                return BadRequest(exp.Message);
            }

        }

        /// <summary>
        /// delete Loyality program account from DB -- allowed manager
        /// </summary>
        [HttpDelete]
        [Route("bonusprogram/{item:long}")]
        [Authorize(Roles ="manager")]
        public async Task<ActionResult> DeleteAsync([FromRoute]long item)
        {
            try
            {
                await ser.DeleteAsync(item);
                return Ok(item);
            }
            catch (Exception exp)
            {
                logger.LogCritical($"Error  while deleting  loyality program for  identificator:{item}");
                return BadRequest(exp.Message);
            }
        }

        /// <summary>
        /// Update Loyality origram details-- allowed manager,operator
        /// </summary>
        [HttpPut]
        [Route("bonusprogram")]
        [Authorize(Roles ="manager,operator")]
        public async Task<ActionResult> UpdateAsync([FromBody]BonusProgramModelIn item)
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
                logger.LogCritical($"Error while  trying update:{exp.Message}");
                return BadRequest(exp.Message);
            }
        }

        /// <summary>
        ///update discount coupon details-- alloowed manager,operator
        /// </summary>
        [HttpPut]
        [Route("coupon")]
        [Authorize(Roles = "manager,operator")]
        public async Task<ActionResult> UpdateCouponAsync([FromBody]CouponModelIn mod)
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
                logger.LogError($"error while trying edit coupon details:{exp.Message}");
                return BadRequest(exp.Message);
            }

        }

        /// <summary>
        /// Delete discount coupon from DB -- allowed manager,operator
        /// </summary>
        [HttpDelete]
        [Route("coupon/{Id:long}")]
        [Authorize(Roles = "manager,operator")]
        public async Task<ActionResult> RemoveCouponAsync([FromRoute]long Id)
        {
            try
            {
                await ser.RemoveCouponAsync(Id);
                return Ok(Id);
            }
            catch (Exception exp)
            {
                logger.LogCritical($"Error while trying remove coupon from DB :{exp.Message}");
                return BadRequest(exp.Message);
            }
        }


        /// <summary>
        /// add new discount coupon to DB -- alllowed manager,operator
        /// </summary>
        [HttpPost]
        [Route("coupon")]
        [Authorize(Roles ="manager,operator")]
        public async Task<ActionResult> AddCouponAsync([FromBody]CouponModelIn mod)
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
                logger.LogTrace($"error while trying add new  discount coupon:{exp.Message}");
                return BadRequest(exp.Message);
            }
        }

        /// <summary>
        /// Get all avalible discount coupons
        /// </summary>
        [HttpGet]
        [Route("coupon")]
        [Authorize(Roles ="manager,operator")]
        public async Task<ActionResult<IEnumerable<CouponModel>>> GetAllCouponAsync()
        {
            try
            {
                var res = await ser.GetAllCouponAsync();
                if (res.Any())
                {
                    return Ok(res);
                }
                return NotFound(ErrorKeys.NotFound);
            }
            catch (Exception exp)
            {
                logger.LogCritical($"Error ocured while trying get data from coupon  {exp.Message}");
                return BadRequest(exp.Message);
            }
        }
    }
}
