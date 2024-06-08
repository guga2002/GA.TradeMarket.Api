using GA.TradeMarket.Application.Interfaces;
using GA.TradeMarket.Application.Models;
using GA.TradeMarket.Application.Models.RequestModels;
using GA.TradeMarket.Application.StaticFIles;
using GA.TradeMarket.Domain.Configurations;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GA.TradeMarket.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public sealed class CustomersController : ControllerBase
    {
        private readonly ICustomerService _customerService;
        private readonly ILogger<CustomersController> _logger;

        public CustomersController(ICustomerService ser,ILogger<CustomersController> logg)
        {
            _customerService = ser;
            this._logger = logg;
        }

        /// <summary>
        /// Get customer Detail info -- allowed admin , manager
        /// </summary>
        [HttpGet]
        [Authorize(Roles ="admin,manager")]
        public async Task<ActionResult<IEnumerable<CustomerModel>>> GetAllWithDetailsAsync()
        {
            try
            {
                var res = await _customerService.GetAllWithDetailsAsync();
                if (res == null)
                {
                    NotFound();
                }
                return Ok(res);
            }
            catch (Exception exp)
            {
                _logger.LogCritical($"Error ocured while sending request  to server:{exp.Message}");
                return BadRequest(exp.Message);
            }
        }

        /// <summary>
        /// Get customer detail by id -- allowed  admin,manager
        /// </summary>
        [HttpGet]
        [Route("{id:long}")]
        [Authorize(Roles = "admin,manager")]
        public async Task<ActionResult<CustomerModel>> GetById([FromRoute]long id)
        {
            try
            {
                if (id < 0) return NotFound();
                var res = await _customerService.GetByIdAsync(id);
                if (res == null)
                {
                    return NotFound(id);
                }
                return Ok(res);
            }
            catch (Exception exp)
            {
                _logger.LogCritical($"Error ocured while sending request  to server:{exp.Message}");
                return BadRequest(exp.Message);
            }
        }

        /// <summary>
        /// Get details about customer by productId -- allowed operator ,manager
        /// </summary>
        [HttpGet]
        [Route("products/{id:long}")]
        [Authorize(Roles ="operator,manager")]
        public async Task<ActionResult<CustomerModel>> GetByProductId([FromRoute]long id)
        {
            try
            {
                if (id < 0) return NotFound();
                var res = await _customerService.GetCustomersByProductIdAsync(id);
                if (res != null)
                {
                    return Ok(res);
                }
                return NotFound(ErrorKeys.NotFound);
            }
            catch (Exception exp)
            {
                _logger.LogCritical($"Error ocured while sending request  to server:{exp.Message}");
                return BadRequest(exp.Message);
            }
        }

        /// <summary>
        /// add new customer to DB -- authorized user is allowed
        /// </summary>
        [HttpPost]
        [Authorize]
        public async Task<ActionResult> AddCustommer([FromBody] CustomerModelIn value)
        {
            try
            {
                if(!ModelState.IsValid)
                {
                    return BadRequest(value);
                }
                if (value.DiscountValue < 0)
                {
                    return BadRequest(ErrorKeys.BadRequest);
                }
                await _customerService.AddAsync(value);
                return Ok(value);
            }
            catch (Exception exp)
            {
                return BadRequest(exp.Message);
            }
        }

        /// <summary>
        /// update customer  details to DB -- authorize user is allowed
        /// </summary>
        [HttpPut]
        [Route("{id:long}")]
        [Authorize]
        public async Task<ActionResult> Put([FromBody] CustomerModelIn value)
        {
            try
            {
                await _customerService.UpdateAsync(value);
                return Ok(value);
            }
            catch (Exception exp)
            {
                _logger.LogCritical($"error ocured while sending request{exp.Message}");
                return BadRequest(exp.Message);
            }
        }

        /// <summary>
        ///delete user  from DB by user id allowed only admin
        /// </summary>
        [HttpDelete]
        [Route("{id:long}")]
        [Authorize(Roles ="admin")]
        public async Task<ActionResult> Delete([FromRoute]long id)

        {
            try
            {
                if (id < 0)
                {
                    return BadRequest(ErrorKeys.BadRequest);
                }
                await _customerService.DeleteAsync(id);
                return Ok(id);
            }
            catch (Exception exp)
            {
                _logger.LogError($"error ocured while admin trying  delete customer,{exp.Message}");
                return BadRequest(exp);
            }
        }

    }
}
