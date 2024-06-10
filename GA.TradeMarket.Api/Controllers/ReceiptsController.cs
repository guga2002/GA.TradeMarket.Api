using GA.TradeMarket.Application.Interfaces;
using GA.TradeMarket.Application.Models;
using GA.TradeMarket.Application.Models.RequestModels;
using GA.TradeMarket.Application.StaticFIles;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace GA.TradeMarket.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public sealed class ReceiptsController : ControllerBase
    {
        private readonly IReceiptService _service;
        private readonly ILogger<ReceiptsController> _logger;
        private readonly IMemoryCache _cache;

        public ReceiptsController(IReceiptService service, ILogger<ReceiptsController> logger, IMemoryCache cache)
        {
            _service = service;
            _logger = logger;
            _cache = cache;
        }

        /// <summary>
        /// Gets all receipts for the current user.
        /// </summary>
        /// <remarks>
        /// This endpoint is for the current user with the role **customer**.
        /// </remarks>
        /// <returns>Returns a list of receipts for the current user.</returns>
        [HttpGet]
        [Route(nameof(AllReceiptsForCurrentUser))]
        [Authorize(Roles = "customer")]
        public async Task<ActionResult<IEnumerable<ReceiptModel>>> AllReceiptsForCurrentUser()
        {
            try
            {
                var user = User.Identity?.Name;
                if (user is null)
                {
                    return Unauthorized(ErrorKeys.NoCustommer);
                }
                var receipts = await _service.GetAllReceiptsForCurrentUser(user);
                return Ok(receipts);
            }
            catch (Exception exp)
            {
                _logger.LogError(exp, "Error fetching all receipts with details");
                return BadRequest($"An error occurred while fetching the receipts. {exp.StackTrace}");
            }
        }

        /// <summary>
        /// Gets details about all receipts.
        /// </summary>
        /// <remarks>
        /// This endpoint is accessible to users with the roles manager, operator. **Enable caching**.
        /// </remarks>
        /// <returns>Returns a list of receipts with details.</returns>
        [HttpGet]
        [Authorize(Roles = "manager,operator")]
        public async Task<ActionResult<IEnumerable<ReceiptModel>>> GetAllWithDetails()
        {
            try
            {
                string cacheKey = "getallreceipts";
                if (_cache.TryGetValue(cacheKey, out IEnumerable<ReceiptModel>? receipts))
                {
                    if (receipts is not null)
                    {
                        return Ok(receipts);
                    }
                }
                var result = await _service.GetAllWithDetailsAsync();
                if (result == null)
                {
                    return NotFound(ErrorKeys.NotFound);
                }
                _cache.Set(cacheKey, result, TimeSpan.FromMinutes(10));
                return Ok(result);
            }
            catch (Exception exp)
            {
                _logger.LogError(exp, "Error fetching all receipts with details");
                return BadRequest("An error occurred while fetching the receipts.");
            }
        }

        /// <summary>
        /// Gets details about a receipt by Id.
        /// </summary>
        /// <remarks>
        /// This endpoint is accessible to users with the roles manager, operator. **Enable caching**.
        /// </remarks>
        /// <param name="id">The Id of the receipt.</param>
        /// <returns>Returns the details of the specified receipt.</returns>
        [HttpGet("{id:long}")]
        [Authorize(Roles = "manager,operator")]
        public async Task<ActionResult<ReceiptModel>> GetById([FromRoute] long id)
        {
            try
            {
                var cacheKey = $"getreceiptbyid{id}";
                if (_cache.TryGetValue(cacheKey, out ReceiptModel? receipt))
                {
                    if (receipt is not null)
                    {
                        return Ok(receipt);
                    }
                }
                var result = await _service.GetByIdAsync(id);
                if (result == null)
                {
                    return NotFound(ErrorKeys.NotFound);
                }
                _cache.Set(cacheKey, result, TimeSpan.FromMinutes(10));
                return Ok(result);
            }
            catch (Exception exp)
            {
                _logger.LogError(exp, $"Error fetching receipt with Id {id}");
                return BadRequest("An error occurred while fetching the receipt.");
            }
        }

        /// <summary>
        /// Gets the details of a receipt.
        /// </summary>
        /// <remarks>
        /// This endpoint is accessible to users with the roles **manager, operator**.
        /// </remarks>
        /// <param name="id">The Id of the receipt.</param>
        /// <returns>Returns the details of the specified receipt.</returns>
        [HttpGet("{id:long}/details")]
        [Authorize(Roles = "manager,operator")]
        public async Task<ActionResult<IEnumerable<ReceiptDetailModel>>> GetDetails([FromRoute] long id)
        {
            try
            {
                string cacheKey = "getallReceiptdetails";
                if (_cache.TryGetValue(cacheKey, out IEnumerable<ReceiptDetailModel>? receiptDetails))
                {
                    if (receiptDetails is not null)
                    {
                        return Ok(receiptDetails);
                    }
                }
                var result = await _service.GetReceiptDetailsAsync(id);
                if (result == null)
                {
                    return NotFound(ErrorKeys.NotFound);
                }
                _cache.Set(cacheKey, result, TimeSpan.FromMinutes(10));
                return Ok(result);
            }
            catch (Exception exp)
            {
                _logger.LogError(exp, $"Error fetching receipt details for Id {id}");
                return BadRequest("An error occurred while fetching the receipt details.");
            }
        }

        /// <summary>
        /// Gets the total amount of a specified receipt.
        /// </summary>
        /// <remarks>
        /// This endpoint is accessible to users with the roles **customer, operator**.
        /// </remarks>
        /// <param name="id">The Id of the receipt.</param>
        /// <returns>Returns the total amount of the specified receipt.</returns>
        [HttpGet("{id:long}/sum")]
        [Authorize(Roles = "customer,operator")]
        public async Task<ActionResult<decimal>> GetReceiptSum([FromRoute] long id)
        {
            try
            {
                var result = await _service.GetReceiptSum(id);
                return Ok(result);
            }
            catch (Exception exp)
            {
                _logger.LogError(exp, $"Error fetching receipt sum for Id {id}");
                return BadRequest("An error occurred while fetching the receipt sum.");
            }
        }

        /// <summary>
        /// Gets receipts within a specified date range.
        /// </summary>
        /// <remarks>
        /// This endpoint is accessible to users with the roles **manager , operator**.
        /// </remarks>
        /// <param name="startDate">The start date of the range.</param>
        /// <param name="endDate">The end date of the range.</param>
        /// <returns>Returns a list of receipts within the specified date range.</returns>
        [HttpGet("period")]
        [Authorize(Roles = "manager,operator")]
        public async Task<ActionResult<IEnumerable<ReceiptModel>>> GetReceiptsByPeriodAsync([FromQuery] DateTime startDate, [FromQuery] DateTime endDate)
        {
            try
            {
                var result = await _service.GetReceiptsByPeriodAsync(startDate, endDate);
                return Ok(result);
            }
            catch (Exception exp)
            {
                _logger.LogError(exp, $"Error fetching receipts between {startDate} and {endDate}");
                return BadRequest("An error occurred while fetching the receipts.");
            }
        }

        /// <summary>
        /// Adds a new receipt to the database.
        /// </summary>
        /// <remarks>
        /// This endpoint is accessible to users with the role **customer**.
        /// </remarks>
        /// <param name="receipt">The receipt to add.</param>
        /// <returns>Returns the added receipt.</returns>
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
        /// Updates a receipt in the database.
        /// </summary>
        /// <remarks>
        /// This endpoint is accessible to users with the roles **manager, operator**.
        /// </remarks>
        /// <param name="id">The Id of the receipt to update.</param>
        /// <param name="receipt">The updated receipt data.</param>
        /// <returns>Returns a status indicating success or failure.</returns>
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
        /// Adds a product to a receipt.
        /// </summary>
        /// <remarks>
        /// This endpoint is accessible to users with the role **customer**.
        /// </remarks>
        /// <param name="id">The Id of the receipt.</param>
        /// <param name="productId">The Id of the product to add.</param>
        /// <param name="quantity">The quantity of the product to add.</param>
        /// <returns>Returns the Id of the receipt.</returns>
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
        /// Removes a product from a receipt.
        /// </summary>
        /// <remarks>
        /// This endpoint is accessible to users with the role **customer**.
        /// </remarks>
        /// <param name="id">The Id of the receipt.</param>
        /// <param name="productId">The Id of the product to remove.</param>
        /// <param name="quantity">The quantity of the product to remove.</param>
        /// <returns>Returns the Id of the receipt.</returns>
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
        /// Pays for the receipt.
        /// </summary>
        /// <remarks>
        /// This endpoint is accessible to users with the roles **customer, operator, manager**.
        /// </remarks>
        /// <param name="id">The Id of the receipt to checkout.</param>
        /// <returns>Returns the Id of the receipt.</returns>
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
        /// Removes a receipt from the database.
        /// </summary>
        /// <remarks>
        /// This endpoint is accessible to users with the role **manager**.
        /// </remarks>
        /// <param name="id">The Id of the receipt to remove.</param>
        /// <returns>Returns the Id of the removed receipt.</returns>
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
