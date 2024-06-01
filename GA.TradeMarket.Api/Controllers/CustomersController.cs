using GA.TradeMarket.Application.Interfaces;
using GA.TradeMarket.Application.Models;
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

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CustomerModel>>> GetAsync()
        {
            var res = await _customerService.GetAllAsync();
            if (res == null)
            {
                NotFound();
            }
            return Ok(res);
        }

        [HttpGet]
        [Route("{id:long}")]
        public async Task<ActionResult<ProductModel>> GetById([FromRoute]long id)
        {
            try
            {
                if (id < 0) return NotFound();
                var res = await _customerService.GetByIdAsync(id);
                if (res == null || res.Name is null || res.Surname is null)
                {
                    return NotFound(id);
                }
                return Ok(res);

            }
            catch (Exception)
            {
                return NotFound();
            }
        }

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
                return NotFound();
            }
            catch (Exception exp)
            {
                return BadRequest(exp);
            }
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] CustomerModel value)
        {
            try
            {
                if (value.Name == string.Empty || value.Surname == string.Empty || value.BirthDate >= DateTime.Now || value.DiscountValue < 0)
                {
                    return BadRequest();
                }
                await _customerService.AddAsync(value);
                return Ok(value);
            }
            catch (Exception exp)
            {
                return BadRequest(exp);
            }
        }

        [HttpPut]
        [Route("{id:long}")]
        public async Task<ActionResult> Put([FromRoute]long Id, [FromBody] CustomerModel value)
        {
            try
            {
                if (value.Name == string.Empty || value.Surname == string.Empty || value.BirthDate >= DateTime.Now || value.DiscountValue < 0)
                {
                    return BadRequest(Id);
                }
                await _customerService.UpdateAsync(value);

                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpDelete]
        [Route("{id:long}")]
        public async Task<ActionResult> Delete([FromRoute]long id)
        {
            try
            {
                if (id < 0)
                {
                    return BadRequest();
                }
                await _customerService.DeleteAsync(id);
                return Ok();
            }
            catch (Exception exp)
            {
                return BadRequest(exp);
            }

        }

    }
}
