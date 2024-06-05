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
    [Authorize]
    public class AfterSoldController : ControllerBase
    {
        private readonly IAfterSoldService ser;
        public AfterSoldController(IAfterSoldService ser)
        {
            this.ser = ser;
        }

        /// <summary>
        /// Get details about ReturnRequest
        /// </summary>
        [HttpGet]
        [Route("returnrequest")]
        public async Task<ActionResult<IEnumerable<ReturnRequestModel>>> GetAllWithDetailsAsync()
        {
            try
            {
                var res = await ser.GetAllWithDetailsAsync();
                if (!res.Any())
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


        /// <summary>
        /// Get details about ReturnRequest by Id
        /// </summary>
        [HttpGet]
        [Route("returnrequest/{Id:long}")]
        public async Task<ActionResult<IEnumerable<ReturnRequestModel>>> GetByIdAsync([FromRoute] long Id)
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
                return BadRequest(exp.Message);
            }
        }

        /// <summary>
        /// add new ReturnRequest to DB
        /// </summary>
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

        /// <summary>
        /// remove the request from db
        /// </summary>
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

        /// <summary>
        /// update request details
        /// </summary>
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

        /// <summary>
        /// update discount review details in db
        /// </summary>
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

        /// <summary>
        /// Removing  review details
        /// </summary>
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

        /// <summary>
        /// Add new review to DB
        /// </summary>
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

        /// <summary>
        /// Get all avalible review
        /// </summary>
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
                return NotFound(ErrorKeys.NotFound);
            }
            catch (Exception exp)
            {
                return BadRequest(exp.Message);
            }
        }
    }
}
