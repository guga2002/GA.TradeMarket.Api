using GA.TradeMarket.Application.Interfaces;
using GA.TradeMarket.Application.Models;
using GA.TradeMarket.Application.Models.RequestModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GA.TradeMarket.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class AfterSoldController : ControllerBase
    {
        private readonly IAfterSoldService ser;
        public AfterSoldController(IAfterSoldService ser)
        {
            this.ser = ser;
        }
        [HttpGet]
        [Route("returnrequest")]
        public async Task<ActionResult<IEnumerable<ReturnRequestModel>>> GetAllWithDetailsAsync()
        {
            try
            {
                var res = await ser.GetAllWithDetailsAsync();
                if (!res.Any())
                {
                    return NotFound();
                }
                return Ok(res);
            }
            catch (Exception exp)
            {
                return BadRequest(exp.Message);
            }
        }

        [HttpGet]
        [Route("returnrequest/{Id:long}")]
        public async Task<ActionResult<IEnumerable<ReturnRequestModel>>> GetByIdAsync([FromRoute] long Id)
        {
            try
            {
                var res = await ser.GetByIdAsync(Id);
                if (res is null)
                {
                    return NotFound();
                }
                return Ok(res);
            }
            catch (Exception exp)
            {
                return BadRequest(exp.Message);
            }
        }

        [HttpPost]
        [Route("returnrequest")]
        public async Task<ActionResult> AddAsync([FromBody] ReturnRequestModelIn item)
        {
            try
            {
                await ser.AddAsync(item);
                return Ok(item);
            }
            catch (Exception exp)
            {
                return BadRequest(exp.Message);
            }

        }

        [HttpDelete]
        [Route("returnrequest/{item:long}")]
        public async Task<ActionResult> DeleteAsync([FromRoute] long item)
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
        [Route("returnrequest")]
        public async Task<ActionResult> UpdateAsync([FromBody] ReturnRequestModelIn item)
        {
            try
            {
                await ser.UpdateAsync(item);
                return Ok(item);
            }
            catch (Exception exp)
            {
                return BadRequest(exp.Message);
            }
        }

        [HttpPut]
        [Route("review")]
        public async Task<ActionResult> UpdateCouponAsync([FromBody] ReviewModelIn mod)
        {
            try
            {
                await ser.UpdateReviewAsync(mod);
                return Ok(mod);
            }
            catch (Exception exp)
            {
                return BadRequest(exp.Message);
            }

        }

        [HttpDelete]
        [Route("review/{Id:long}")]
        public async Task<ActionResult> RemoveCouponAsync([FromRoute] long Id)
        {
            try
            {
                await ser.RemoveReviewAsync(Id);
                return Ok(Id);
            }
            catch (Exception exp)
            {
                return BadRequest(exp.Message);
            }
        }

        [HttpPost]
        [Route("review")]
        public async Task<ActionResult> AddCouponAsync([FromBody] ReviewModelIn mod)
        {
            try
            {
                await ser.AddReviewAsync(mod);
                return Ok(mod);
            }
            catch (Exception exp)
            {
                return BadRequest(exp.Message);
            }
        }

        [HttpGet]
        [Route("review")]
        public async Task<ActionResult<IEnumerable<ReviewModel>>> GetAllCouponAsync()
        {
            try
            {
                var res = await ser.GetAllReviewsAsync();
                if (res.Any())
                {
                    return Ok(res);
                }
                return NotFound();
            }
            catch (Exception exp)
            {
                return BadRequest(exp.Message);
            }
        }
    }
}
