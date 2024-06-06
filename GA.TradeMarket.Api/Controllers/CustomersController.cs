using GA.TradeMarket.Application.Interfaces;
using GA.TradeMarket.Application.Models;
using GA.TradeMarket.Application.Models.RequestModels;
using GA.TradeMarket.Application.StaticFIles;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GA.TradeMarket.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerService _customerService;


        public CustomersController(ICustomerService ser)
        {
            _customerService = ser;
        }

        /// <summary>
        /// Get customer Detail info
        /// </summary>
        [HttpGet]
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
                return BadRequest(exp.Message);
            }
        }

        /// <summary>
        /// Get customer detail by id
        /// </summary>
        [HttpGet]
        [Route("{id:long}")]
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
                return BadRequest(exp.Message);
            }
        }

        /// <summary>
        /// Get details about customer by productId
        /// </summary>
        [HttpGet]
        [Route("products/{id:long}")]
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
                return BadRequest(exp);
            }
        }

        /// <summary>
        /// add new customer to DB
        /// </summary>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] CustomerReqModel value)
        {
            try
            {
                if (value.Name == string.Empty || value.Surname == string.Empty || value.BirthDate >= DateTime.Now || value.DiscountValue < 0)
                {
                    return BadRequest(ErrorKeys.BadRequest);
                }
                await _customerService.AddAsync(value);
                return Ok(value);
            }
            catch (Exception exp)
            {
                return BadRequest(exp);
            }
        }

        /// <summary>
        /// update customer  details to DB
        /// </summary>
        [HttpPut]
        [Route("{id:long}")]
        public async Task<ActionResult> Put([FromRoute]long Id, [FromBody] CustomerReqModel value)
        {
            try
            {
                if (value.Name == string.Empty || value.Surname == string.Empty || value.BirthDate >= DateTime.Now || value.DiscountValue < 0)
                {
                    return BadRequest(Id);
                }
                await _customerService.UpdateAsync(value);
                return Ok(value);
            }
            catch (Exception exp)
            {
                return BadRequest(exp.Message);
            }
        }

        /// <summary>
        ///delete user  from DB by user id
        /// </summary>
        [HttpDelete]
        [Route("{id:long}")]
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
                return BadRequest(exp);
            }
        }

    }
}
