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
    public class ReceiptsController : ControllerBase
    {

        private readonly IReceiptService ser;

        public ReceiptsController(IReceiptService se)
        {
            ser = se;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ReceiptModel>>> Get()
        {
            var res = await ser.GetAllAsync();
            if (res == null)
            {
                return NotFound();
            }
            return Ok(res);
        }

        [HttpGet("{Id:long}")]
        public async Task<ActionResult<ReceiptModel>> GetById([FromRoute]long id)
        {
            var res = await ser.GetByIdAsync(id);
            if (res == null)
            {
                return NotFound();
            }
            return Ok(res);
        }

        [HttpGet("{id:long}/details")]
        public async Task<ActionResult<IEnumerable<ReceiptDetailModel>>> GetDetails([FromRoute] long id)
        {
            var res = await ser.GetReceiptDetailsAsync(id);
            if (res == null)
            {
                return NotFound();
            }
            return Ok(res);
        }

        [HttpGet("{id:long}/sum")]
        public async Task<ActionResult<decimal>> GetReceiptSum([FromRoute]long id)
        {
            var res = await ser.GetReceiptSum(id);

            return Ok(res);
        }

        [HttpGet("period")]
        public async Task<ActionResult<IEnumerable<ReceiptModel>>> GetReceiptsByPeriodAsync(DateTime startDate, DateTime endDate)
        {
            var res = await ser.GetReceiptsByPeriodAsync(startDate, endDate);
            return Ok(res);
        }

        [HttpPost]
        public async Task<ActionResult> CreateReceipt([FromBody] ReceiptModel receipt)
        {

            if (receipt == null) return BadRequest();
            await ser.AddAsync(receipt);
            return Ok(receipt);
        }

        [HttpPut("{id:long}")]
        public async Task<IActionResult> UpdateReceipt([FromRoute] long id, [FromBody] ReceiptModel receipt)
        {
            if (receipt == null) return BadRequest();
            await ser.UpdateAsync(receipt);
            return Ok();
        }

        [HttpPut("{id:long}/products/add/{productId:long}/{quantity:int}")]
        public async Task<IActionResult> AddProductToReceipt([FromRoute]long id, [FromRoute]long productId,[FromQuery] int quantity)
        {

            await ser.AddProductAsync(id, productId, quantity);
            return Ok("good");
        }

        [HttpPut("{id:long}/products/remove/{productId:long}/{quantity:int}")]
        public async Task<IActionResult> RemoveProductFromReceipt([FromRoute] long id, [FromRoute] long productId, [FromQuery] int quantity)
        {

            await ser.RemoveProductAsync(productId, id, quantity);
            return Ok();
        }

        [HttpPut("{id:long}/checkout")]
        public async Task<IActionResult> CheckoutReceipt([FromRoute]long id)
        {
            await ser.CheckOutAsync(id);
            return Ok();
        }

        [HttpDelete("{id:long}")]
        public async Task<IActionResult> DeleteReceipt([FromRoute]long id)
        {
            await ser.DeleteAsync(id);
            return Ok();
        }

    }
}
