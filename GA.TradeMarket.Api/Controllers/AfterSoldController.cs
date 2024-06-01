using GA.TradeMarket.Application.Interfaces;
using GA.TradeMarket.Application.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GA.TradeMarket.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AfterSoldController : ControllerBase
    {
        private readonly IAfterSoldService ser;
        public AfterSoldController(IAfterSoldService ser)
        {
            this.ser = ser;
        }
        [HttpGet]
        [Route("returnrequest")]
        public async Task<ActionResult<IEnumerable<ReturnRequestModel>>> GetAllAsync()
        {
            try
            {
                var res = await ser.GetAllAsync();
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
                if (res is not null)
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
        public async Task<ActionResult> AddAsync([FromBody] ReturnRequestModel item)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    await ser.AddAsync(item);
                    return Ok(item);
                }
                return BadRequest("Insert was not succesfully");
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
        public async Task<ActionResult> UpdateAsync([FromBody] ReturnRequestModel item)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    await ser.UpdateAsync(item);
                    return Ok(item);
                }
                return BadRequest("Update was not succesfully");
            }
            catch (Exception exp)
            {
                return BadRequest(exp.Message);
            }
        }

        [HttpPut]
        [Route("review")]
        public async Task<ActionResult> UpdateCouponAsync([FromBody] ReviewModel mod)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    await ser.UpdateReviewAsync(mod);
                    return Ok(mod);
                }
                return BadRequest("Update was not succesfully");
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
        public async Task<ActionResult> AddCouponAsync([FromBody] ReviewModel mod)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    await ser.AddReviewAsync(mod);
                    return Ok(mod);
                }
                return BadRequest("Insert was not succesfully");
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
                if (!ModelState.IsValid)
                {
                    var res = await ser.GetAllReviewsAsync();
                    if (res.Any())
                    {
                        return Ok(res);
                    }
                    return NotFound();
                }
                return BadRequest("Retrive data was not succesfully");
            }
            catch (Exception exp)
            {
                return BadRequest(exp.Message);
            }
        }
    }
}
