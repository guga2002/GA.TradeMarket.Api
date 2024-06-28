using GA.TradeMarket.Application.Interfaces;
using GA.TradeMarket.Application.Models;
using GA.TradeMarket.Application.Models.RequestModels;
using GA.TradeMarket.Application.StaticFIles;
using GA.TradeMarket.Application.Validation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace GA.TradeMarket.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShippingController : ControllerBase
    {
        private readonly IShippingService ser;
        private readonly ILogger<ShippingController> logger;
        private readonly IMemoryCache cash;
        public ShippingController(IShippingService ser, ILogger<ShippingController> logger, IMemoryCache cash)
        {
            this.ser = ser;
            this.logger = logger;
            this.cash = cash;
        }

        /// <summary>
        /// get details about shippings 
        /// </summary>
        /// <remarks>
        /// Allow Manager, operator  **enable cashing**
        /// </remarks>
        [HttpGet]
        [Route("shipping")]
        [Authorize(Roles = "operator,manager")]
        public async Task<ActionResult<IEnumerable<ShippingModel>>> GetAllWithDetailsAsync()
        {
            var encryptkey = "getallshipping";
            if (cash.TryGetValue(encryptkey, out IEnumerable<ShippingModel>? result))
            {
                if (result is not null)
                {
                    return Ok(result);
                }
            }
            var res = await ser.GetAllWithDetailsAsync();
            if (!res.Any())
            {
                return NotFound(ErrorKeys.NotFound);
            }
            cash.Set(encryptkey, res, TimeSpan.FromMinutes(10));
            return Ok(res);
        }

        /// <summary>
        /// Get details about shipping by Id 
        /// </summary>
        /// <remarks>
        /// Allow Manager, operator  **enable cashing**
        /// </remarks>
        [HttpGet]
        [Route("shipping/{Id:long}")]
        [Authorize(Roles = "manager,operator")]
        public async Task<ActionResult<ShippingModel>> GetByIdAsync([FromRoute] long Id)
        {
            string encryptKey = $"SHippngById{Id}";
            if (cash.TryGetValue(encryptKey, out IEnumerable<ShippingModel>? result))
            {
                if (result is not null)
                {
                    return Ok(result);
                }
            }
            var res = await ser.GetByIdAsync(Id);
            if (res is null)
            {
                return NotFound(ErrorKeys.NotFound);
            }
            cash.Set(encryptKey, res, TimeSpan.FromMinutes(10));
            return Ok(res);
        }

        /// <summary>
        /// Add new shipping to DB 
        /// </summary>
        /// <remarks>
        /// allow **operator,manager**
        /// </remarks>
        [HttpPost]
        [Route("shipping")]
        [Authorize(Roles = "operator,manager")]
        public async Task<ActionResult> AddAsync([FromBody] ShippingModelIn item)
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

        /// <summary>
        /// delete specify shipping history
        /// </summary>
        /// <<remarks>
        /// allow only **Manager**
        /// </remarks>
        [HttpDelete]
        [Route("shipping/{Id:long}")]
        [Authorize(Roles = "manager")]
        public async Task<ActionResult> DeleteAsync([FromRoute] long Id)
        {
            await ser.DeleteAsync(Id);
            return Ok(Id);
        }

        /// <summary>
        /// update specify shipping to DB
        /// </summary>
        /// <remarks>
        /// allow **Operator, manager**
        /// </remarks>
        [HttpPut]
        [Route("shipping")]
        [Authorize(Roles = "operator,manager")]
        public async Task<ActionResult> UpdateAsync([FromBody] ShippingModelIn item)
        {
            if (!ModelState.IsValid)
            {
                throw new MarketException(ErrorKeys.InternalServerError);
            }
            await ser.UpdateAsync(item);
            return Ok(item);
        }

        /// <summary>
        ///Update specify Notification to DB 
        /// </summary>
        /// <remarks>
        /// allow  **manager, operator**
        /// </remarks>
        [HttpPut]
        [Route("Notification")]
        [Authorize(Roles = "operator,manager")]
        public async Task<ActionResult> UpdateNotificationAsync([FromBody] NotificationModelIn mod)
        {
            if (!ModelState.IsValid)
            {
                throw new MarketException(ErrorKeys.InternalServerError);
            }
            await ser.UpdateNotificationAsync(mod);
            return Ok(mod);
        }

        /// <summary>
        ///delete specify notification from DB 
        /// </summary>
        /// <remarks>
        /// allow only **manager**
        /// </remarks>
        [HttpDelete]
        [Route("Notification/{Id:long}")]
        [Authorize(Roles = "manager")]
        public async Task<ActionResult> RemoveNotificationAsync([FromRoute] long Id)
        {
            await ser.RemoveNotificationAsync(Id);
            return Ok(Id);
        }
        /// <summary>
        ///Retrive notification which is not sent yet
        /// </summary>
        /// <remarks>
        /// allow **operator,manager**
        /// </remarks>
        [HttpGet]
        [Route(nameof(AllUnsendNotifications))]
        [Authorize(Roles = "operator,manager")]
        public async Task<ActionResult<IEnumerable<NotificationModel>>> AllUnsendNotifications()
        {
            var res = await ser.GetAllUnsentNotifications();
            if (res.Any())
            {
                return Ok(res);
            }
            return NotFound(ErrorKeys.NotFound);
        }

        /// <summary>
        ///send all advertisments to users 
        /// </summary>
        /// <remarks>
        /// allowed  **operator,manager**
        /// </remarks>
        [HttpGet]
        [Route(nameof(SendNotificationstoUsers))]
        [Authorize(Roles = "operator,manager")]
        public async Task<ActionResult> SendNotificationstoUsers()
        {
            await ser.SendNotificationstoUsers();
            return Ok();
        }

        /// <summary>
        ///add new notification to DB
        /// </summary>
        /// <remarks>
        /// allow **operator,manager**
        /// </remarks>
        [HttpPost]
        [Route("Notification")]
        [Authorize(Roles = "operator,manager")]
        public async Task<ActionResult> AddNotificationAsync([FromBody] NotificationModelIn mod)
        {
            if (!ModelState.IsValid)
            {
                throw new MarketException($"{ErrorKeys.InternalServerError}");
            }
            await ser.AddNotificationAsync(mod);
            return Ok(mod);
        }
        /// <summary>
        /// get all notifications 
        /// </summary>
        /// <remarks>
        /// allow operator,manager  -- **enable cashing**
        /// </remarks>
        [HttpGet]
        [Route("Notification")]
        [Authorize(Roles = "operator,manager")]
        public async Task<ActionResult<IEnumerable<NotificationModel>>> GetAllNotificationAsync()
        {
            var cashKey = "Allnotifications";
            if (cash.TryGetValue(cashKey, out IEnumerable<NotificationModel>? notification))
            {
                if (notification is not null)
                {
                    return Ok(notification);
                }
            }
            var res = await ser.GetAllNotificationAsync();
            if (res.Any())
            {
                cash.Set(cashKey, res, TimeSpan.FromMinutes(10));
                return Ok(res);
            }
            return NotFound(ErrorKeys.NotFound);
        }

        /// <summary>
        /// update shippping status 
        /// </summary>
        /// <remarks>
        /// allow  only **operator and manager**
        /// </remarks>
        [HttpPut]
        [Route(nameof(ShippingStatus))]
        [Authorize(Roles = "operator,manager")]
        public async Task<ActionResult<bool>> ShippingStatus([FromBody] ShippingStatusUpdateModel update)
        {
            var res = await ser.UpdateShippingStatus(update);
            if (res)
            {
                return Ok(update);
            }
            return NotFound(ErrorKeys.NotFound);

        }
    }
}
