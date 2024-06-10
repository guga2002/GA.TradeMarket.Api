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
    public sealed class AfterSoldController : ControllerBase
    {
        private readonly IAfterSoldService ser;
        private readonly ILogger<AfterSoldController> logger;
        private readonly IMemoryCache cash;

        public AfterSoldController(IAfterSoldService ser, ILogger<AfterSoldController> sold, IMemoryCache cash)
        {
            this.ser = ser;
            this.logger = sold;
            this.cash = cash;
        }

        /// <summary>
        /// Gets all return requests made by the current user.
        /// </summary>
        /// <remarks>
        /// This endpoint is accessible to users with the role "customer".
        /// </remarks>
        /// <returns>Returns a list of return requests made by the current user.</returns>
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
                logger.LogCritical($"Error occurred while sending request to server: {exp.Message}");
                return BadRequest(exp.Message);
            }
        }

        /// <summary>
        /// Gets all return requests with details.
        /// </summary>
        /// <remarks>
        /// This endpoint is accessible to users with the roles "operator" and "manager". **Caching** is enabled for this endpoint.
        /// </remarks>
        /// <returns>Returns a list of return requests with details.</returns>
        [HttpGet]
        [Route("returnrequest")]
        [Authorize(Roles = "operator,manager")]
        public async Task<ActionResult<IEnumerable<ReturnRequestModel>>> GetAllWithDetailsAsync()
        {
            try
            {
                string cachedKey = "GetAllReturnRequest";
                if (cash.TryGetValue(cachedKey, out IEnumerable<ReturnRequestModel>? returnreq))
                {
                    if (returnreq is not null)
                    {
                        return Ok(returnreq);
                    }
                }
                var res = await ser.GetAllWithDetailsAsync();
                if (!res.Any())
                {
                    return NotFound(ErrorKeys.NotFound);
                }
                cash.Set(cachedKey, res, TimeSpan.FromMinutes(10));
                return Ok(res);
            }
            catch (Exception exp)
            {
                logger.LogError($"Error occurred while sending request to retrieve all data: {exp.Message}");
                return BadRequest(exp.Message);
            }
        }

        /// <summary>
        /// Gets details about a return request by Id.
        /// </summary>
        /// <remarks>
        /// This endpoint is accessible to users with the roles "operator" and "manager". **Caching** is enabled for this endpoint.
        /// </remarks>
        /// <param name="Id">The Id of the return request.</param>
        /// <returns>Returns the details of the specified return request.</returns>
        [HttpGet]
        [Route("returnrequest/{Id:long}")]
        [Authorize(Roles = "operator,manager")]
        public async Task<ActionResult<ReturnRequestModel>> GetByIdAsync([FromRoute] long Id)
        {
            try
            {
                var cachedKey = $"getallreturnreq{Id}";
                if (cash.TryGetValue(cachedKey, out ReturnRequestModel? returnreq))
                {
                    if (returnreq is not null)
                    {
                        return Ok(returnreq);
                    }
                }
                var res = await ser.GetByIdAsync(Id);
                if (res is null)
                {
                    return NotFound(ErrorKeys.NotFound);
                }
                cash.Set(cachedKey, res, TimeSpan.FromMinutes(10));
                return Ok(res);
            }
            catch (Exception exp)
            {
                logger.LogDebug($"Error occurred while trying to fetch data from server, identifier: {Id}");
                return BadRequest(exp.Message);
            }
        }

        /// <summary>
        /// Adds a new return request to the database.
        /// </summary>
        /// <remarks>
        /// This endpoint is accessible to users with the role "customer".
        /// </remarks>
        /// <param name="item">The return request data to add.</param>
        /// <returns>Returns the added return request.</returns>
        [HttpPost]
        [Route("returnrequest")]
        [Authorize(Roles = "customer")]
        public async Task<ActionResult> AddAsync([FromBody] ReturnRequestModelIn item)
        {
            try
            {
                await ser.AddAsync(item);
                return Ok(item);
            }
            catch (Exception exp)
            {
                logger.LogError($"Error while customer trying to add a new return request to the database. Order Id: {item.OrderId}");
                return BadRequest(exp.Message);
            }
        }

        /// <summary>
        /// Removes a return request from the database.
        /// </summary>
        /// <remarks>
        /// This endpoint is accessible to users with the role "manager".
        /// </remarks>
        /// <param name="id">The Id of the return request to remove.</param>
        /// <returns>Returns the Id of the removed return request.</returns>
        [HttpDelete]
        [Route("returnrequest/{id:long}")]
        [Authorize(Roles = "manager")]
        public async Task<ActionResult> DeleteAsync([FromRoute] long id)
        {
            try
            {
                await ser.DeleteAsync(id);
                return Ok(id);
            }
            catch (Exception exp)
            {
                logger.LogCritical($"Error occurred while admin trying to delete item from database, Id: {id}");
                return BadRequest(exp.Message);
            }
        }

        /// <summary>
        /// Updates the details of a return request.
        /// </summary>
        /// <remarks>
        /// This endpoint is accessible to users with the roles "manager" and "operator".
        /// </remarks>
        /// <param name="item">The updated return request data.</param>
        /// <returns>Returns the updated return request.</returns>
        [HttpPut]
        [Route("returnrequest")]
        [Authorize(Roles = "manager,operator")]
        public async Task<ActionResult> UpdateAsync([FromBody] ReturnRequestModelIn item)
        {
            try
            {
                await ser.UpdateAsync(item);
                return Ok(item);
            }
            catch (Exception exp)
            {
                logger.LogCritical($"Error while trying to edit details about return request: {exp.Message}");
                return BadRequest(exp.Message);
            }
        }

        /// <summary>
        /// Updates the review details in the database.
        /// </summary>
        /// <remarks>
        /// This endpoint is accessible to users with the role "manager".
        /// </remarks>
        /// <param name="mod">The updated review data.</param>
        /// <returns>Returns the updated review data.</returns>
        [HttpPut]
        [Route("review")]
        [Authorize(Roles = "manager")]
        public async Task<ActionResult> UpdateReviewAsync([FromBody] ReviewModelIn mod)
        {
            try
            {
                await ser.UpdateReviewAsync(mod);
                return Ok(mod);
            }
            catch (Exception exp)
            {
                logger.LogCritical($"Error while trying to edit details about review: {exp.Message}");
                return BadRequest(exp.Message);
            }
        }

        /// <summary>
        /// Removes a review from the database.
        /// </summary>
        /// <remarks>
        /// This endpoint is accessible to users with the role "manager".
        /// </remarks>
        /// <param name="Id">The Id of the review to remove.</param>
        /// <returns>Returns the Id of the removed review.</returns>
        [HttpDelete]
        [Route("review/{Id:long}")]
        [Authorize(Roles = "manager")]
        public async Task<ActionResult> RemoveReviewAsync([FromRoute] long Id)
        {
            try
            {
                await ser.RemoveReviewAsync(Id);
                return Ok(Id);
            }
            catch (Exception exp)
            {
                logger.LogCritical($"Error occurred while trying to remove data from server, identifier: {Id}");
                return BadRequest(exp.Message);
            }
        }

        /// <summary>
        /// Adds a new review to the database.
        /// </summary>
        /// <remarks>
        /// This endpoint is accessible to users with the role **customer**.
        /// </remarks>
        /// <param name="mod">The review data to add.</param>
        /// <returns>Returns the added review data.</returns>
        [HttpPost]
        [Route("review")]
        [Authorize(Roles = "customer")]
        public async Task<ActionResult> AddReviewAsync([FromBody] ReviewModelIn mod)
        {
            try
            {
                await ser.AddReviewAsync(mod);
                return Ok(mod);
            }
            catch (Exception exp)
            {
                logger.LogError($"Error occurred while operator trying to add a new review to the database: {exp.Message}");
                return BadRequest(exp.Message);
            }
        }

        /// <summary>
        /// Gets all available reviews.
        /// </summary>
        /// <remarks>
        /// This endpoint is accessible to users with the roles "operator" and "manager". **Caching** is enabled for this endpoint.
        /// </remarks>
        /// <returns>Returns a list of available reviews.</returns>
        [HttpGet]
        [Route("review")]
        [Authorize(Roles = "operator,manager")]
        public async Task<ActionResult<IEnumerable<ReviewModel>>> GetAllReviewsAsync()
        {
            try
            {
                var cachedKey = "AllReviews";
                if (cash.TryGetValue(cachedKey, out IEnumerable<ReviewModel>? result))
                {
                    if (result is not null)
                    {
                        return Ok(result);
                    }
                }
                var res = await ser.GetAllReviewsAsync();
                if (res.Any())
                {
                    cash.Set(cachedKey, res, TimeSpan.FromMinutes(10));
                    return Ok(res);
                }
                return NotFound(ErrorKeys.NotFound);
            }
            catch (Exception exp)
            {
                logger.LogCritical($"Error occurred while operator/manager was trying to fetch data from server: {exp.Message}");
                return BadRequest(exp.Message);
            }
        }
    }
}
