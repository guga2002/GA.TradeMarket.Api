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
    public class ShippingController : ControllerBase
    {
        private readonly IShippingService ser;
        public ShippingController(IShippingService ser)
        {
                this.ser = ser;
        }

        [HttpGet]
        [Route("shipping")]
        public async Task<ActionResult<IEnumerable<ShippingModel>>> GetAllWithDetailsAsync()
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
        [Route("shipping/{Id:long}")]
        public async Task<ActionResult<IEnumerable<ShippingModel>>> GetByIdAsync([FromRoute] long Id)
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

        [HttpPut]
        [Route("Notification")]
        public async Task<ActionResult> UpdateCouponAsync([FromBody] NotificationModelIn mod)
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

        [HttpDelete]
        [Route("Notification/{Id:long}")]
        public async Task<ActionResult> RemoveCouponAsync([FromRoute] long Id)
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

        [HttpPost]
        [Route("Notification")]
        public async Task<ActionResult> AddCouponAsync([FromBody] NotificationModelIn mod)
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

        [HttpGet]
        [Route("Notification")]
        public async Task<ActionResult<IEnumerable<NotificationModel>>> GetAllCouponAsync()
        {
            try
            {
                    var res = await ser.GetAllNotificationAsync();
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
