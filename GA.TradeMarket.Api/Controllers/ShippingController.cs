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
    public class ShippingController : ControllerBase
    {
        private readonly IShippingService ser;
        public ShippingController(IShippingService ser)
        {
                this.ser = ser;
        }

        /// <summary>
        /// get details about shippings
        /// </summary>
        [HttpGet]
        [Route("shipping")]
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
                return BadRequest(exp.Message);
            }
        }

        /// <summary>
        /// Get details about shipping by Id
        /// </summary>
        [HttpGet]
        [Route("shipping/{Id:long}")]
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
                return BadRequest(exp.Message);
            }
        }

        /// <summary>
        /// add new shipping to DB
        /// </summary>
        [HttpPost]
        [Route("shipping")]
        public async Task<ActionResult> AddAsync([FromBody] ShippingModelIn item)
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
        /// delete specify shipping history
        /// </summary>
        [HttpDelete]
        [Route("shipping/{Id:long}")]
        public async Task<ActionResult> DeleteAsync([FromRoute] long Id)
        {
            try
            {
                await ser.DeleteAsync(Id);
                return Ok(Id);
            }
            catch (Exception exp)
            {
                return BadRequest(exp.Message);
            }
        }

        /// <summary>
        /// update specify shipping to DB
        /// </summary>
        [HttpPut]
        [Route("shipping")]
        public async Task<ActionResult> UpdateAsync([FromBody] ShippingModelIn item)
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
        ///Update specify Notification to DB
        /// </summary>
        [HttpPut]
        [Route("Notification")]
        public async Task<ActionResult> UpdateNotificationAsync([FromBody] NotificationModelIn mod)
        {
            try
            {
                await ser.UpdateNotificationAsync(mod);
                return Ok(mod);
            }
            catch (Exception exp)
            {
                return BadRequest(exp.Message);
            }

        }

        /// <summary>
        ///delete specify notification from DB
        /// </summary>
        [HttpDelete]
        [Route("Notification/{Id:long}")]
        public async Task<ActionResult> RemoveNotificationAsync([FromRoute] long Id)
        {
            try
            {
                await ser.RemoveNotificationAsync(Id);
                return Ok(Id);
            }
            catch (Exception exp)
            {
                return BadRequest(exp.Message);
            }
        }

        /// <summary>
        ///add new notification to DB
        /// </summary>
        [HttpPost]
        [Route("Notification")]
        public async Task<ActionResult> AddNotificationAsync([FromBody] NotificationModelIn mod)
        {
            try
            {
                await ser.AddNotificationAsync(mod);
                return Ok(mod);
            }
            catch (Exception exp)
            {
                return BadRequest(exp.Message);
            }
        }

        /// <summary>
        /// get all notifications
        /// </summary>
        [HttpGet]
        [Route("Notification")]
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
                return BadRequest(exp.Message);
            }
        }
    }
}
