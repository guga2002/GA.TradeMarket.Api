using GA.TradeMarket.Application.Interfaces;
using GA.TradeMarket.Application.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GA.TradeMarket.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class PaymentController : ControllerBase
    {
        private readonly IPaymentService ser;

        public PaymentController(IPaymentService ser)
        {
            this.ser = ser;
        }
        [HttpGet]
        [Route("payment")]
        public async Task<ActionResult<IEnumerable<PaymentModel>>> GetAllAsync()
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
        [Route("payment/{Id:long}")]
        public async Task<ActionResult<IEnumerable<PaymentModel>>> GetByIdAsync([FromRoute] long Id)
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
        [Route("payment")]
        public async Task<ActionResult> AddAsync([FromBody] PaymentModel item)
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
        [Route("payment/{item:long}")]
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
        [Route("payment")]
        public async Task<ActionResult> UpdateAsync([FromBody] PaymentModel item)
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
        [Route("PaymentMethod")]
        public async Task<ActionResult> UpdateCouponAsync([FromBody] PaymentMethodModel mod)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    await ser.UpdatePaymentMethodAsync(mod);
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
        [Route("PaymentMethod/{Id:long}")]
        public async Task<ActionResult> RemoveCouponAsync([FromRoute] long Id)
        {
            try
            {
                await ser.RemovePayMentMethodAsync(Id);
                return Ok(Id);
            }
            catch (Exception exp)
            {
                return BadRequest(exp.Message);
            }
        }

        [HttpPost]
        [Route("PaymentMethod")]
        public async Task<ActionResult> AddCouponAsync([FromBody] PaymentMethodModel mod)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    await ser.AddPaymentMethodAsync(mod);
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
        [Route("PaymentMethod")]
        public async Task<ActionResult<IEnumerable<PaymentMethodModel>>> GetAllCouponAsync()
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    var res = await ser.GetAllPaymentMethodAsync();
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
