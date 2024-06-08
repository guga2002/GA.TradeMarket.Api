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
    public sealed class ReceiptsController : ControllerBase
    {
        private readonly IReceiptService _service;
        private readonly ILogger<ReceiptsController> _logger;

        public ReceiptsController(IReceiptService service, ILogger<ReceiptsController> logger)
        {
            _service = service;
            _logger = logger;
        }

        /// <summary>
        /// Get details about receipts history for current user
        /// </summary>
        [HttpGet]
        [Route(nameof(AllReceiptsForCurrentUser))]
        [Authorize(Roles ="customer")]
        public async Task<ActionResult<IEnumerable<ReceiptModel>>> AllReceiptsForCurrentUser()
        {
            try
            {
                var user = User.Identity?.Name;
                if(user is null)
                {
                    return Unauthorized(ErrorKeys.NoCustommer);
                }
                var re=await _service.GetAllReceiptsForCurrentUser(user);
                return Ok(re);
            }
            catch (Exception exp)
            {
                _logger.LogError(exp, "Error fetching all receipts with details");
                return BadRequest($"An error occurred while fetching the receipts.{exp.StackTrace}");
            }
        }

        /// <summary>
        /// Get details about receipts  --- Allow Manager,operator
        /// </summary>
        [HttpGet]
        [Authorize(Roles = "manager,operator")]
        public async Task<ActionResult<IEnumerable<ReceiptModel>>> GetAllWithDetails()
        {
            try
            {
                var res = await _service.GetAllWithDetailsAsync();
                if (res == null)
                {
                    return NotFound(ErrorKeys.NotFound);
                }
                return Ok(res);
            }
            catch (Exception exp)
            {
                _logger.LogError(exp, "Error fetching all receipts with details");
                return BadRequest("An error occurred while fetching the receipts.");
            }
        }

        /// <summary>
        /// Get details about receipt by Id   --- Allow Manager,operator
        /// </summary>
        [HttpGet("{id:long}")]
        [Authorize(Roles = "manager,operator")]
        public async Task<ActionResult<ReceiptModel>> GetById([FromRoute] long id)
        {
            try
            {
                var res = await _service.GetByIdAsync(id);
                if (res == null)
                {
                    return NotFound(ErrorKeys.NotFound);
                }
                return Ok(res);
            }
            catch (Exception exp)
            {
                _logger.LogError(exp, $"Error fetching receipt with Id {id}");
                return BadRequest("An error occurred while fetching the receipt.");
            }
        }

        /// <summary>
        /// Get receipt details   --- Allow Manager,operator
        /// </summary>
        [HttpGet("{id:long}/details")]
        [Authorize(Roles = "manager,operator")]
        public async Task<ActionResult<IEnumerable<ReceiptDetailModel>>> GetDetails([FromRoute] long id)
        {
            try
            {
                var res = await _service.GetReceiptDetailsAsync(id);
                if (res == null)
                {
                    return NotFound(ErrorKeys.NotFound);
                }
                return Ok(res);
            }
            catch (Exception exp)
            {
                _logger.LogError(exp, $"Error fetching receipt details for Id {id}");
                return BadRequest("An error occurred while fetching the receipt details.");
            }
        }

        /// <summary>
        /// Get total amount of specified Receipt    --- Allow Customer,opearator
        /// </summary>
        [HttpGet("{id:long}/sum")]
        [Authorize(Roles = "customer,opearator")]
        public async Task<ActionResult<decimal>> GetReceiptSum([FromRoute] long id)
        {
            try
            {
                var res = await _service.GetReceiptSum(id);
                return Ok(res);
            }
            catch (Exception exp)
            {
                _logger.LogError(exp, $"Error fetching receipt sum for Id {id}");
                return BadRequest("An error occurred while fetching the receipt sum.");
            }
        }

        /// <summary>
        /// Get Receipts within a specified date range  --- Allow Manager,operator
        /// </summary>
        [HttpGet("period")]
        [Authorize(Roles = "manager,operator")]
        public async Task<ActionResult<IEnumerable<ReceiptModel>>> GetReceiptsByPeriodAsync([FromQuery] DateTime startDate, [FromQuery] DateTime endDate)
        {
            try
            {
                var res = await _service.GetReceiptsByPeriodAsync(startDate, endDate);
                return Ok(res);
            }
            catch (Exception exp)
            {
                _logger.LogError(exp, $"Error fetching receipts between {startDate} and {endDate}");
                return BadRequest("An error occurred while fetching the receipts.");
            }
        }

        /// <summary>
        /// Add a new receipt to the DB  --- Allow Customer
        /// </summary>
        [HttpPost]
        [Authorize(Roles = "customer")]
        public async Task<ActionResult> CreateReceipt([FromBody] ReceiptModelIn receipt)
        {
            try
            {
                if (receipt == null)
                {
                    return BadRequest(ErrorKeys.BadRequest);
                }
                if (!ModelState.IsValid)
                {
                    return BadRequest(ErrorKeys.General);
                }
                await _service.AddAsync(receipt);
                return Ok(receipt);
            }
            catch (Exception exp)
            {
                _logger.LogError(exp, "Error creating a new receipt");
                return BadRequest("An error occurred while creating the receipt.");
            }
        }

        /// <summary>
        /// Update a receipt in the DB  --- Allow Manager,operator
        /// </summary>
        [HttpPut("{id:long}")]
        [Authorize(Roles = "manager,operator")]
        public async Task<IActionResult> UpdateReceipt([FromRoute] long id, [FromBody] ReceiptModelIn receipt)
        {
            try
            {
                if (receipt == null)
                {
                    return BadRequest(ErrorKeys.BadRequest);
                }
                await _service.UpdateAsync(receipt);
                return Ok();
            }
            catch (Exception exp)
            {
                _logger.LogError(exp, $"Error updating receipt with Id {id}");
                return BadRequest("An error occurred while updating the receipt.");
            }
        }

        /// <summary>
        /// Add a product to a receipt  --- Allow Customer
        /// </summary>
        [HttpPut("{id:long}/products/add/{productId:long}/{quantity:int}")]
        [Authorize(Roles = "customer")]
        public async Task<IActionResult> AddProductToReceipt([FromRoute] long id, [FromRoute] long productId, [FromQuery] int quantity)
        {
            try
            {
                await _service.AddProductAsync(id, productId, quantity);
                return Ok(id);
            }
            catch (Exception exp)
            {
                _logger.LogError(exp, $"Error adding product {productId} to receipt {id}");
                return BadRequest("An error occurred while adding the product to the receipt.");
            }
        }

        /// <summary>
        /// Remove a product from a receipt  --- Allow Customer
        /// </summary>
        [HttpPut("{id:long}/products/remove/{productId:long}/{quantity:int}")]
        [Authorize(Roles = "customer")]
        public async Task<IActionResult> RemoveProductFromReceipt([FromRoute] long id, [FromRoute] long productId, [FromQuery] int quantity)
        {
            try
            {
                await _service.RemoveProductAsync(productId, id, quantity);
                return Ok(id);
            }
            catch (Exception exp)
            {
                _logger.LogError(exp, $"Error removing product {productId} from receipt {id}");
                return BadRequest("An error occurred while removing the product from the receipt.");
            }
        }

        /// <summary>
        /// Pay for the receipt --- Allow Customer,operator,manager
        /// </summary>
        [HttpPut("{id:long}/checkout")]
        [Authorize(Roles = "customer,operator,manager")]
        public async Task<IActionResult> CheckoutReceipt([FromRoute] long id)
        {
            try
            {
                await _service.CheckOutAsync(id);
                return Ok(id);
            }
            catch (Exception exp)
            {
                _logger.LogError(exp, $"Error checking out receipt {id}");
                return BadRequest("An error occurred while checking out the receipt.");
            }
        }

        /// <summary>
        /// Remove a receipt from the DB  --- Allow Manager
        /// </summary>
        [HttpDelete("{id:long}")]
        [Authorize(Roles = "manager")]
        public async Task<IActionResult> DeleteReceipt([FromRoute] long id)
        {
            try
            {
                await _service.DeleteAsync(id);
                return Ok(id);
            }
            catch (Exception exp)
            {
                _logger.LogError(exp, $"Error deleting receipt {id}");
                return BadRequest("An error occurred while deleting the receipt.");
            }
        }
    }
}
