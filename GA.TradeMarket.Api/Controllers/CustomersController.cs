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
    public sealed class CustomersController : ControllerBase
    {
        private readonly ICustomerService _customerService;
        private readonly ILogger<CustomersController> _logger;

        public CustomersController(ICustomerService ser, ILogger<CustomersController> logg)
        {
            _customerService = ser;
            this._logger = logg;
        }

        /// <summary>
        /// Get customer detail information.
        /// </summary>
        /// <remarks>
        /// This endpoint is accessible to users with the roles "admin" and "manager".
        /// </remarks>
        /// <returns>Returns a list of customer models with details.</returns>
        [HttpGet]
        [Authorize(Roles = "admin,manager")]
        public async Task<ActionResult<IEnumerable<CustomerModel>>> GetAllWithDetailsAsync()
        {
            var res = await _customerService.GetAllWithDetailsAsync();
            if (res == null)
            {
                return NotFound();
            }
            return Ok(res);
        }

        /// <summary>
        /// Get customer detail by id.
        /// </summary>
        /// <remarks>
        /// This endpoint is accessible to users with the roles "admin" and "manager".
        /// </remarks>
        /// <param name="id">The ID of the customer.</param>
        /// <returns>Returns the customer model for the specified ID.</returns>
        [HttpGet]
        [Route("{id:long}")]
        [Authorize(Roles = "admin,manager")]
        public async Task<ActionResult<CustomerModel>> GetById([FromRoute] long id)
        {
            if (id < 0) return NotFound();
            var res = await _customerService.GetByIdAsync(id);
            if (res == null)
            {
                return NotFound(id);
            }
            return Ok(res);
        }

        /// <summary>
        /// Get customer details by product ID.
        /// </summary>
        /// <remarks>
        /// This endpoint is accessible to users with the roles "operator" and "manager".
        /// </remarks>
        /// <param name="id">The ID of the product.</param>
        /// <returns>Returns the customer model for the specified product ID.</returns>
        [HttpGet]
        [Route("products/{id:long}")]
        [Authorize(Roles = "operator,manager")]
        public async Task<ActionResult<CustomerModel>> GetByProductId([FromRoute] long id)
        {

            if (id < 0) return NotFound();
            var res = await _customerService.GetCustomersByProductIdAsync(id);
            if (res != null)
            {
                return Ok(res);
            }
            return NotFound(ErrorKeys.NotFound);
        }

        /// <summary>
        /// Add a new customer to the database.
        /// </summary>
        /// <remarks>
        /// This endpoint is accessible to authorized users.
        /// </remarks>
        /// <param name="value">The customer model to add.</param>
        /// <returns>Returns the added customer model.</returns>
        [HttpPost]
        [Authorize]
        public async Task<ActionResult> AddCustommer([FromBody] CustomerModelIn value)
        {
            if (!ModelState.IsValid)
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

        /// <summary>
        /// Update customer details in the database.
        /// </summary>
        /// <remarks>
        /// This endpoint is accessible to authorized users.
        /// </remarks>
        /// <param name="value">The customer model with updated details.</param>
        /// <returns>Returns the updated customer model.</returns>
        [HttpPut]
        [Route("{id:long}")]
        [Authorize]
        public async Task<ActionResult> Put([FromBody] CustomerModelIn value)
        {
            await _customerService.UpdateAsync(value);
            return Ok(value);
        }

        /// <summary>
        /// Delete a customer from the database by user ID.
        /// </summary>
        /// <remarks>
        /// This endpoint is accessible to users with the role "admin".
        /// </remarks>
        /// <param name="id">The ID of the customer to delete.</param>
        /// <returns>Returns the ID of the deleted customer.</returns>
        [HttpDelete]
        [Route("{id:long}")]
        [Authorize(Roles = "admin")]
        public async Task<ActionResult> Delete([FromRoute] long id)
        {
            if (id < 0)
            {
                return BadRequest(ErrorKeys.BadRequest);
            }
            await _customerService.DeleteAsync(id);
            return Ok(id);
        }
    }
}
