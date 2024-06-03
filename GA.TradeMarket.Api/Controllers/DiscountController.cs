using GA.TradeMarket.Application.Interfaces;
using GA.TradeMarket.Application.Models;
using GA.TradeMarket.Application.Models.RequestModels;
using GA.TradeMarket.Application.StaticFIles;
using Microsoft.AspNetCore.Mvc;

namespace GA.TradeMarket.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiscountController : ControllerBase
    {
        private readonly IDiscountService ser;

        public DiscountController(IDiscountService ser)
        {
                this.ser=ser;
        }

        [HttpGet]
        [Route("bonusprogram")]
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
                return BadRequest(exp.Message);
            }
        }

        [HttpGet]
        [Route("bonusprogram/{Id:long}")]
        public async Task<ActionResult<IEnumerable<CouponModel>>> GetByIdAsync([FromRoute]long Id)
        {
            try
            {
                var res = await ser.GetByIdAsync(Id);
                if (res is not null)
                {
                    return NotFound(ErrorKeys.NotFound);
                }
                return Ok(res);
            }
            catch (Exception exp)
            {
                return BadRequest(exp.Message);
            }
        }

        [HttpPost]
        [Route("bonusprogram")]
        public async Task<ActionResult> AddAsync([FromBody]BonusProgramModelIn item)
        {
            try
            {
                if(!ModelState.IsValid)
                {
                    await ser.AddAsync(item);
                    return Ok(item);
                }
                return BadRequest(ErrorKeys.UnsuccesfullInsert);
            }
            catch (Exception exp)
            {
                return BadRequest(exp.Message);
            }

        }

        [HttpDelete]
        [Route("bonusprogram/{item:long}")]
        public async Task<ActionResult> DeleteAsync([FromRoute]long item)
        {
            try
            {
                await ser.DeleteAsync(item);
                return Ok(item);
            }
            catch (Exception exp)
            {
                return BadRequest(exp.Message);
            }
        }
        [HttpPut]
        [Route("bonusprogram")]
        public async Task<ActionResult> UpdateAsync([FromBody]BonusProgramModelIn item)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    await ser.UpdateAsync(item);
                    return Ok(item);
                }
                return BadRequest(ErrorKeys.UnsucessfullUpdate);
            }
            catch (Exception exp)
            {
                return BadRequest(exp.Message);
            }
        }

        [HttpPut]
        [Route("coupon")]
        public async Task<ActionResult> UpdateCouponAsync([FromBody]CouponModelIn mod)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    await ser.UpdateCouponAsync(mod);
                    return Ok(mod);
                }
                return BadRequest(ErrorKeys.UnsucessfullUpdate);
            }
            catch (Exception exp)
            {
                return BadRequest(exp.Message);
            }

        }

        [HttpDelete]
        [Route("coupon/{Id:long}")]
        public async Task<ActionResult> RemoveCouponAsync([FromRoute]long Id)
        {
            try
            {
                await ser.RemoveCouponAsync(Id);
                return Ok(Id);
            }
            catch (Exception exp)
            {
                return BadRequest(exp.Message);
            }
        }

        [HttpPost]
        [Route("coupon")]
        public async Task<ActionResult> AddCouponAsync([FromBody]CouponModelIn mod)
        {
            try
            {
                    await ser.AddCouponAsync(mod);
                    return Ok(mod);
            }
            catch (Exception exp)
            {
                return BadRequest(exp.Message);
            }
        }

        [HttpGet]
        [Route("coupon")]
        public async Task<ActionResult<IEnumerable<CouponModel>>> GetAllCouponAsync()
        {
            try
            {
                    var res=await ser.GetAllCouponAsync();
                    if (res.Any())
                    {
                        return Ok(res);
                    }
                    return NotFound(ErrorKeys.NotFound);
            }
            catch (Exception exp)
            {
                return BadRequest(exp.Message);
            }
        }
    }
}
