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
    public sealed class AfterSoldController : ControllerBase
    {
        private readonly IAfterSoldService ser;
        private readonly ILogger<AfterSoldController> logger;
        public AfterSoldController(IAfterSoldService ser,ILogger<AfterSoldController> sold)
        {
            this.ser = ser;
            this.logger = sold;
        }

        /// <summary>
        /// Get details  return request which is made by current user -- allow customer
        /// </summary>
        [HttpGet]
        [Route(nameof(GetAllMyReturnRequests))]
        [Authorize(Roles = "customer")]
        public async Task<ActionResult<IEnumerable<ReturnRequestModel>>> GetAllMyReturnRequests()
        {
            try
            {
                if (User.Identity?.Name is not null)
                {
                    var res = await ser.GetAllMyReturnRequests(User.Identity.Name);
                    if (!res.Any())
                    {
                        return NotFound(ErrorKeys.NotFound);
                    }
                    return Ok(res);
                }
                return Unauthorized(ErrorKeys.General);
            }
            catch (Exception exp)
            {
                logger.LogCritical($"Error ocured while sending request to server{exp.Message}");
                return BadRequest(exp.Message);
            }
        }



        /// <summary>
        /// Get details about ReturnRequest --allow Operator, Manager
        /// </summary>
        [HttpGet]
        [Route("returnrequest")]
        [Authorize(Roles = "operator,manager")]
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
                logger.LogError($"error ocured while sending request to retrive all data, following error{exp.Message}");
                return BadRequest(exp.Message);
            }
        }


        /// <summary>
        /// Get details about ReturnRequest by Id -- allow Operator, Manager
        /// </summary>
        [HttpGet]
        [Route("returnrequest/{Id:long}")]
        [Authorize(Roles = "operator,manager")]
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
                logger.LogDebug($"error ocured while  trying fetch data from server , identificator: {Id}");
                return BadRequest(exp.Message);
            }
        }

        /// <summary>
        /// add new ReturnRequest to DB -- allow customer
        /// </summary>
        [HttpPost]
        [Route("returnrequest")]
        [Authorize(Roles ="customer")]
        public async Task<ActionResult> AddAsync([FromBody] ReturnRequestModelIn item)
        {
            try
            {
                await ser.AddAsync(item);
                return Ok(item);
            }
            catch (Exception exp)
            {
                logger.LogError($"Error while customer trying  to add  new returnrequeast to DB, Order Id is : {item.OrderId}");
                return BadRequest(exp.Message);
            }
        }

        /// <summary>
        /// remove the request from db -- allow manager
        /// </summary>
        [HttpDelete]
        [Route("returnrequest/{id:long}")]
        [Authorize("manager")]
        public async Task<ActionResult> DeleteAsync([FromRoute] long id)
        {
            try
            {
                await ser.DeleteAsync(id);
                return Ok(id);
            }
            catch (Exception exp)
            {
                logger.LogCritical($"We have Errror  while adming trying , to delete item from db, whith Id: {id}");
                return BadRequest(exp.Message);
            }
        }

        /// <summary>
        /// update request details-- allow operator,Manager
        /// </summary>
        [HttpPut]
        [Route("returnrequest")]
        [Authorize(Roles ="manager,operator")]
        public async Task<ActionResult> UpdateAsync([FromBody] ReturnRequestModelIn item)
        {
            try
            {
                await ser.UpdateAsync(item);
                return Ok(item);
            }
            catch (Exception exp)
            {
                logger.LogCritical($"Error whoile trying edit details about return request{exp.Message}");
                return BadRequest(exp.Message);
            }
        }

        /// <summary>
        /// update discount review details in db -- allow manager
        /// </summary>
        [HttpPut]
        [Route("review")]
        [Authorize(Roles = "manager")]
        public async Task<ActionResult> UpdateCouponAsync([FromBody] ReviewModelIn mod)
        {
            try
            {
                await ser.UpdateReviewAsync(mod);
                return Ok(mod);
            }
            catch (Exception exp)
            {
                logger.LogCritical($"Error while trying edit details about return request{exp.Message}");
                return BadRequest(exp.Message);
            }
        }

        /// <summary>
        /// Removing  review details -- allow manager
        /// </summary>
        [HttpDelete]
        [Route("review/{Id:long}")]
        [Authorize(Roles ="manager")]
        public async Task<ActionResult> RemoveCouponAsync([FromRoute] long Id)
        {
            try
            {
                await ser.RemoveReviewAsync(Id);
                return Ok(Id);
            }
            catch (Exception exp)
            {
                logger.LogCritical("Error ocured while trying, remove data from server, data identificator:Id");
                return BadRequest(exp.Message);
            }
        }

        /// <summary>
        /// Add new review to DB -- allow operator
        /// </summary>
        [HttpPost]
        [Route("review")]
        [Authorize(Roles ="operator")]
        public async Task<ActionResult> AddCouponAsync([FromBody] ReviewModelIn mod)
        {
            try
            {
                await ser.AddReviewAsync(mod);
                return Ok(mod);
            }
            catch (Exception exp)
            {
                logger.LogError($"Error ocured, while operator  trying add coupon to db, following error must check:{exp.Message}");
                return BadRequest(exp.Message);
            }
        }

        /// <summary>
        /// Get all avalible review-- allow operator,manager
        /// </summary>
        [HttpGet]
        [Route("review")]
        [Authorize(Roles ="operator,manager")]
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
                logger.LogCritical($"Error: {exp.Message} ocured, while  operator, manager were trying to fetch data from server");
                return BadRequest(exp.Message);
            }
        }
    }
}
