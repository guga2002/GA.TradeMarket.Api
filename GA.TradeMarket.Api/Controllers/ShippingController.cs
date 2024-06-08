using GA.TradeMarket.Application.Interfaces;
using GA.TradeMarket.Application.Models;
using GA.TradeMarket.Application.Models.RequestModels;
using GA.TradeMarket.Application.StaticFIles;
using GA.TradeMarket.Application.Validation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GA.TradeMarket.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShippingController : ControllerBase
    {
        private readonly IShippingService ser;
        private  readonly ILogger<ShippingController> logger;
        public ShippingController(IShippingService ser, ILogger<ShippingController> logger)
        {
            this.ser = ser;
            this.logger = logger;
        }

        /// <summary>
        /// get details about shippings -- Allow Manager, operator
        /// </summary>
        [HttpGet]
        [Route("shipping")]
        [Authorize(Roles ="operator,manager")]
        public async Task<ActionResult<IEnumerable<ShippingModel>>> GetAllWithDetailsAsync()
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
                logger.LogError($"Errror ocured while sending request to server{exp.Message}");
                return BadRequest(exp.Message);
            }
        }

        /// <summary>
        /// Get details about shipping by Id  -- Allow Manager, operator
        /// </summary>
        [HttpGet]
        [Route("shipping/{Id:long}")]
        [Authorize(Roles ="manager,operator")]
        public async Task<ActionResult<IEnumerable<ShippingModel>>> GetByIdAsync([FromRoute] long Id)
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
                logger.LogError($"Errror ocured while sending request to server{exp.Message}");
                return BadRequest(exp.Message);
            }
        }

        /// <summary>
        /// add new shipping to DB -- allow operator,manager
        /// </summary>
        [HttpPost]
        [Route("shipping")]
        [Authorize(Roles ="operator,manager")]
        public async Task<ActionResult> AddAsync([FromBody] ShippingModelIn item)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await ser.AddAsync(item);
                    return Ok(item);
                }
                else
                {
                    throw new MarketException(ErrorKeys.InternalServerError);
                }
            }
            catch (Exception exp)
            {
                logger.LogError($"Errro ocured while sending request{exp.Message}");
                return BadRequest(exp.Message);
            }

        }

        /// <summary>
        /// delete specify shipping history --- allow Manager
        /// </summary>
        [HttpDelete]
        [Route("shipping/{Id:long}")]
        [Authorize(Roles ="manager")]
        public async Task<ActionResult> DeleteAsync([FromRoute] long Id)
        {
            try
            {
                await ser.DeleteAsync(Id);
                return Ok(Id);
            }
            catch (Exception exp)
            {
                logger.LogCritical($"Following error ocured while sending request to server{exp.Message}");
                return BadRequest(exp.Message);
            }
        }

        /// <summary>
        /// update specify shipping to DB -- allow Operator manager
        /// </summary>
        [HttpPut]
        [Route("shipping")]
        [Authorize(Roles ="operator,manager")]
        public async Task<ActionResult> UpdateAsync([FromBody] ShippingModelIn item)
        {
            try
            {
                if(!ModelState.IsValid)
                {
                    throw new MarketException(ErrorKeys.InternalServerError);
                }
                await ser.UpdateAsync(item);
                return Ok(item);
            }
            catch (Exception exp)
            {
                logger.LogError($"Following error ocured while sending request to server{exp.Message}");
                return BadRequest(exp.Message);
            }
        }

        /// <summary>
        ///Update specify Notification to DB -- allow manager, operator
        /// </summary>
        [HttpPut]
        [Route("Notification")]
        [Authorize(Roles ="operator,manager")]
        public async Task<ActionResult> UpdateNotificationAsync([FromBody] NotificationModelIn mod)
        {
            try
            {
                if(!ModelState.IsValid)
                {
                    throw new MarketException(ErrorKeys.InternalServerError);
                }
                await ser.UpdateNotificationAsync(mod);
                return Ok(mod);
            }
            catch (Exception exp)
            {
                logger.LogError($"Following error ocured while sending request to server{exp.Message}");
                return BadRequest(exp.Message);
            }

        }

        /// <summary>
        ///delete specify notification from DB -- allow manager
        /// </summary>
        [HttpDelete]
        [Route("Notification/{Id:long}")]
        [Authorize(Roles ="manager")]
        public async Task<ActionResult> RemoveNotificationAsync([FromRoute] long Id)
        {
            try
            {
                await ser.RemoveNotificationAsync(Id);
                return Ok(Id);
            }
            catch (Exception exp)
            {
                logger.LogCritical($"Following error ocured while sending request to server{exp.Message}");
                return BadRequest(exp.Message);
            }
        }
        /// <summary>
        ///Retrive notification which is not sent yet --allow operator,manager
        /// </summary>
        [HttpGet]
        [Route(nameof(AllUnsendNotifications))]
        [Authorize(Roles = "operator,manager")]
        public async Task<ActionResult<IEnumerable<NotificationModel>>> AllUnsendNotifications()
        {
            try
            {
                var res = await ser.GetAllUnsentNotifications();
                if(res.Any())
                {
                    return Ok(res);
                }
                return NotFound(ErrorKeys.NotFound);
            }
            catch (Exception exp)
            {
                logger.LogCritical($"Following error ocured while sending request to server{exp.Message}");
                return BadRequest(exp.Message);
            }
        }

        /// <summary>
        ///send all advertisments to users -- allowed operator,manager
        /// </summary>
        [HttpGet]
        [Route(nameof(SendNotificationstoUsers))]
        [Authorize(Roles ="operator,manager")]
        public async Task<ActionResult> SendNotificationstoUsers()
        {
            try
            {
                await ser.SendNotificationstoUsers();
                return Ok();
            }
            catch (Exception exp)
            {
                logger.LogCritical($"Following error ocured while sending request to server{exp.Message}");
                return BadRequest(exp.Message);
            }
        }

        /// <summary>
        ///add new notification to DB --allow operator,manager
        /// </summary>
        [HttpPost]
        [Route("Notification")]
        [Authorize(Roles = "operator,manager")]
        public async Task<ActionResult> AddNotificationAsync([FromBody] NotificationModelIn mod)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    throw new MarketException($"{ErrorKeys.InternalServerError}");
                }
                await ser.AddNotificationAsync(mod);
                return Ok(mod);
            }
            catch (Exception exp)
            {
                logger.LogCritical($"Following error ocured while sending request to server{exp.Message}");
                return BadRequest(exp.Message);
            }
        }

        /// <summary>
        /// get all notifications -- allow operator,manager
        /// </summary>
        [HttpGet]
        [Route("Notification")]
        [Authorize("operator,manager")]
        public async Task<ActionResult<IEnumerable<NotificationModel>>> GetAllNotificationAsync()
        {
            try
            {
                var res = await ser.GetAllNotificationAsync();
                if (res.Any())
                {
                    return Ok(res);
                }
                return NotFound(ErrorKeys.NotFound);
            }
            catch (Exception exp)
            {
                logger.LogCritical($"Following error ocured while sending request to server{exp.Message}");
                return BadRequest(exp.Message);
            }
        }

        /// <summary>
        /// update shippping status -- allow  only operator and manager
        /// </summary>
        [HttpPut]
        [Route(nameof(ShippingStatus))]
        [Authorize(Roles ="operator,manager")]
        public async Task<ActionResult<bool>> ShippingStatus([FromBody] ShippingStatusUpdateModel update)
        {
            try
            {
                var res = await ser.UpdateShippingStatus(update);
                if(res)
                {
                    return Ok(update);
                }
                return NotFound(ErrorKeys.NotFound);
            }
            catch (Exception exp)
            {
                logger.LogCritical($"Following error ocured while sending request to server{exp.Message}");
                return BadRequest(exp.Message);
            }
        }
    }
}
