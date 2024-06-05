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
    public class ReceiptsController : ControllerBase
    {

        private readonly IReceiptService ser;

        public ReceiptsController(IReceiptService se)
        {
            ser = se;
        }

        /// <summary>
        /// Get details about receipts
        /// </summary>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ReceiptModel>>> GetAllWIthDetails()
        {
            var res = await ser.GetAllWithDetailsAsync();
            if (res == null)
            {
                return NotFound(ErrorKeys.NotFound);
            }
            return Ok(res);
        }

        /// <summary>
        /// Get details about receipt by Id
        /// </summary>
        [HttpGet("{Id:long}")]
        public async Task<ActionResult<ReceiptModel>> GetById([FromRoute]long id)
        {
            try
            {
                var res = await ser.GetByIdAsync(id);
                if (res == null)
                {
                    return NotFound(ErrorKeys.NotFound);
                }
                return Ok(res);
            }
            catch (Exception exp)
            {
                return BadRequest(exp.Message);
            }
        }

        /// <summary>
        /// Get receiptDetals
        /// </summary>
        [HttpGet("{id:long}/details")]
        public async Task<ActionResult<IEnumerable<ReceiptDetailModel>>> GetDetails([FromRoute] long id)
        {
            var res = await ser.GetReceiptDetailsAsync(id);
            if (res == null)
            {
                return NotFound(ErrorKeys.NotFound);
            }
            return Ok(res);
        }

        /// <summary>
        /// Get total Amount of specify Receipt
        /// </summary>
        [HttpGet("{id:long}/sum")]
        public async Task<ActionResult<decimal>> GetReceiptSum([FromRoute]long id)
        {
            var res = await ser.GetReceiptSum(id);

            return Ok(res);
        }

        /// <summary>
        /// Get Receipts  to specify data range
        /// </summary>
        [HttpGet("period")]
        public async Task<ActionResult<IEnumerable<ReceiptModel>>> GetReceiptsByPeriodAsync(DateTime startDate, DateTime endDate)
        {
            var res = await ser.GetReceiptsByPeriodAsync(startDate, endDate);
            return Ok(res);
        }

        /// <summary>
        /// Add new receipt ro DB
        /// </summary>
        [HttpPost]
        public async Task<ActionResult> CreateReceipt([FromBody] ReceiptModelIn receipt)
        {

            if (receipt == null) return BadRequest(ErrorKeys.BadRequest);
            await ser.AddAsync(receipt);
            return Ok(receipt);
        }

        /// <summary>
        /// Update new receipt to DB
        /// </summary>
        [HttpPut("{id:long}")]
        public async Task<IActionResult> UpdateReceipt([FromRoute] long id, [FromBody] ReceiptModelIn receipt)
        {
            if (receipt == null) return BadRequest(ErrorKeys.BadRequest);
            await ser.UpdateAsync(receipt);
            return Ok();
        }

        /// <summary>
        /// Add specify product to Cart
        /// </summary>
        [HttpPut("{id:long}/products/add/{productId:long}/{quantity:int}")]
        public async Task<IActionResult> AddProductToReceipt([FromRoute]long id, [FromRoute]long productId,[FromQuery] int quantity)
        {

            await ser.AddProductAsync(id, productId, quantity);
            return Ok(id);
        }

        /// <summary>
        /// Remove specify product from Cart
        /// </summary>
        [HttpPut("{id:long}/products/remove/{productId:long}/{quantity:int}")]
        public async Task<IActionResult> RemoveProductFromReceipt([FromRoute] long id, [FromRoute] long productId, [FromQuery] int quantity)
        {

            await ser.RemoveProductAsync(productId, id, quantity);
            return Ok(id);
        }

        /// <summary>
        /// pay for the receipt
        /// </summary>
        [HttpPut("{id:long}/checkout")]
        public async Task<IActionResult> CheckoutReceipt([FromRoute]long id)
        {
            await ser.CheckOutAsync(id);
            return Ok(id);
        }

        /// <summary>
        /// remove specify receipt from DB
        /// </summary>
        [HttpDelete("{id:long}")]
        public async Task<IActionResult> DeleteReceipt([FromRoute]long id)
        {
            await ser.DeleteAsync(id);
            return Ok(id);
        }

    }
}
