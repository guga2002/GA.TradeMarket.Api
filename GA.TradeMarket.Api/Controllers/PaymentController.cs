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
    public sealed class PaymentController : ControllerBase
    {
        private readonly IPaymentService ser;
        private readonly ILogger<PaymentController> logger;

        public PaymentController(IPaymentService ser,ILogger<PaymentController>log)
        {
            this.ser = ser;
            this.logger = log;
        }

        /// <summary>
        /// Get all avalible payments 
        /// </summary>
        /// <remarks>
        ///  allowed -- **operators and managers**
        /// </remarks>
        [HttpGet]
        [Route("payment")]
        [Authorize(Roles ="operator,manager")]
        public async Task<ActionResult<IEnumerable<PaymentModel>>> GetAllWithDetailsAsync()
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
                logger.LogError($"error while retrieving datas{exp.Message}");
                return BadRequest(exp.Message);
            }
        }

        /// <summary>
        /// Get payment detail by id
        /// </summary>
        /// <remarks>
        /// allowed  **operator,manager**
        /// </remarks>
        [HttpGet]
        [Route("payment/{Id:long}")]
        [Authorize(Roles = "operator,manager")]
        public async Task<ActionResult<IEnumerable<PaymentModel>>> GetByIdAsync([FromRoute] long Id)
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
                logger.LogCritical($"error while retrieving specify payment {Id} error:{exp.Message}");
                return BadRequest(exp.Message);
            }
        }

        /// <summary>
        /// get payme methods for current user
        /// </summary>
        /// <remarks>
        /// allow **customer**
        /// </remarks>
        [HttpGet]
        [Route(nameof(PaymentMethodForCurrentUser))]
        [Authorize(Roles ="customer")]
        public async Task<ActionResult<PaymentMethodModel>> PaymentMethodForCurrentUser()
        {
            try
            {
                var userName = User.Identity?.Name;
                if (userName is null)
                {
                    return Unauthorized(ErrorKeys.General);
                }
                var res = await ser.GetallPaymentMethodForCurrentUser(userName);
                return Ok(res);
            }
            catch (Exception exp)
            {
                logger.LogCritical($"error while retrieving specify payment method for current user, error:{exp.Message}");
                return BadRequest(exp.StackTrace);
            }
        }


        /// <summary>
        /// get payme methods for current user 
        /// </summary>
        /// <remarks>
        /// allow  **customer**
        /// </remarks>
        [HttpGet]
        [Route(nameof(PaymentForCurrentUser))]
        [Authorize(Roles = "customer")]
        public async Task<ActionResult<PaymentMethodModel>> PaymentForCurrentUser()
        {
            try
            {
                var userName = User.Identity?.Name;
                if (userName is null)
                {
                    return Unauthorized(ErrorKeys.General);
                }
                var res = await ser.GetallPaymentForCurrentUser(userName);
                return Ok(res);
            }
            catch (Exception exp)
            {
                logger.LogCritical($"error while retrieving specify payment for current user, error:{exp.Message}");
                return BadRequest(exp.Message);
            }
        }

        /// <summary>
        /// Add customer payment detail to DB 
        /// </summary>
        /// <remarks>
        ///  allow  customer
        /// </remarks>
        [HttpPost]
        [Route("payment")]
        [Authorize(Roles ="customer")]
        public async Task<ActionResult> AddAsync([FromBody] PaymentModelIn item)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await ser.AddAsync(item);
                    return Ok(item);
                }
                return BadRequest(ErrorKeys.General);
            }
            catch (Exception exp)
            {
                logger.LogError($"error mesage while add  entity in db:{exp.Message}");
                return BadRequest(exp.Message);
            }
        }

        /// <summary>
        /// delete payment detail by id
        /// </summary>
        /// <remarks>
        ///  allowed  only **managers**
        /// </remarks>
        [HttpDelete]
        [Route("payment/{item:long}")]
        [Authorize(Roles ="manager")]
        public async Task<ActionResult> DeleteAsync([FromRoute] long item)
        {
            try
            {
                await ser.DeleteAsync(item);
                return Ok(item);
            }
            catch (Exception exp)
            {
                logger.LogCritical($"error while trying delete: {exp.Message}");
                return BadRequest(exp.Message);
            }
        }

        /// <summary>
        ///update payment details to DB 
        /// </summary>
        /// <remarks>
        ///  allowed **customer,operator**
        /// </remarks>
        [HttpPut]
        [Route("payment")]
        [Authorize(Roles ="operator,customer")]
        public async Task<ActionResult> UpdateAsync([FromBody] PaymentModelIn item)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await ser.UpdateAsync(item);
                    return Ok(item);
                }
                return BadRequest(ErrorKeys.General);
            }
            catch (Exception exp)
            {
                logger.LogError($"error while editing payment {exp.Message}");
                return BadRequest(exp.Message);
            }
        }

        /// <summary>
        /// update payment method details in DB 
        /// </summary>
        /// <remarks>
        /// allowed **customer,operator**
        /// </remarks>
        [HttpPut]
        [Route("PaymentMethod")]
        [Authorize(Roles ="customer,operator")]
        public async Task<ActionResult> UpdateCouponAsync([FromBody] PaymentMethodModelIn mod)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await ser.UpdatePaymentMethodAsync(mod);
                    return Ok(mod);
                }
                return BadRequest(ErrorKeys.InternalServerError);
            }
            catch (Exception exp)
            {
                logger.LogError($"Error {exp.Message}");
                return BadRequest(exp.Message);
            }

        }

        /// <summary>
        /// remove specify payment method by id
        /// </summary>
        /// <remarks>
        /// allow **customer,operator,manager**
        /// </remarks>
        [HttpDelete]
        [Route("PaymentMethod/{Id:long}")]
        [Authorize(Roles ="customer,operator,manager")]
        public async Task<ActionResult> RemovePaymentMethod([FromRoute] long Id)
        {
            try
            {
                await ser.RemovePayMentMethodAsync(Id);
                return Ok(Id);
            }
            catch (Exception exp)
            {
                logger.LogCritical($"error while removing payment method: {exp.Message}");
                return BadRequest(exp.Message);
            }
        }

        /// <summary>
        /// add specify payment method details to DB
        /// </summary>
        /// <remarks>
        /// allowed **customer**
        /// </remarks>
        [HttpPost]
        [Route("PaymentMethod")]
        [Authorize(Roles ="customer")]
        public async Task<ActionResult> AddPaymentMethod([FromBody] PaymentMethodModelIn mod)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await ser.AddPaymentMethodAsync(mod);
                    return Ok(mod);
                }
                return BadRequest(ErrorKeys.BadRequest);
            }
            catch (Exception exp)
            {
                logger.LogCritical($"error while adding payment method:{exp.Message}");
                return BadRequest(exp.Message);
            }
        }

        /// <summary>
        /// get all payment method details 
        /// </summary>
        /// <remarks>
        /// allowed **operator,manager**
        /// </remarks>
        [HttpGet]
        [Route("PaymentMethod")]
        [Authorize(Roles ="operator,manager")]
        public async Task<ActionResult<IEnumerable<PaymentMethodModel>>> GetAllPaymentMethodAsync()
        {
            try
            {
                var res = await ser.GetAllPaymentMethodAsync();
                if (res.Any())
                {
                    return Ok(res);
                }
                return NotFound(ErrorKeys.NotFound);
            }
            catch (Exception exp)
            {
                logger.LogCritical($"Errro while getting  payment methods:{exp.Message}");
                return BadRequest(exp.Message);
            }
        }
    }
}
