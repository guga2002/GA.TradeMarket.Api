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
    [Authorize]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService ser;
        public OrderController(IOrderService se)
        {
                this.ser= se;
        }

        /// <summary>
        /// Get details about orders
        /// </summary>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<OrderModel>>> GetAllWithDetailsAsync()
        {
            try
            {
                var res=await ser.GetAllWithDetailsAsync();
                if(res.Any())
                {
                    return Ok(res);
                }
                return BadRequest(res);
            }
            catch (Exception exp)
            {
                return BadRequest(exp.Message);
            }
        }

        /// <summary>
        /// Get details about order by id
        /// </summary>
        [HttpGet]
        [Route("{id:long}")]
        public async Task<ActionResult> GetByIdAsync([FromRoute]long Id)
        {
            try
            {
               var res=await ser.GetByIdAsync(Id);
                if(res is not null)
                {
                    return Ok(res);
                }
                return NotFound(Id);
            }
            catch (Exception exp)
            {
                return BadRequest(exp.Message);
            }
        }

        /// <summary>
        ///add new order to DB
        /// </summary>
        [HttpPost]
        public async Task<ActionResult> AddAsync([FromBody]OrderModelIn item)
        {
            try
            {
                await ser.AddAsync(item);
                return Ok(item);
            }
            catch (Exception exp)
            {
                return BadRequest(exp.Message);
            }
        }

        /// <summary>
        ///  remove order from DB
        /// </summary>
        [HttpDelete]
        [Route("{Id:long}")]
        public async Task<ActionResult> DeleteAsync(long Id)
        {
            try
            {
                await ser.DeleteAsync(Id);
                return Ok(Id);
            }
            catch (Exception exp)
            {
                return BadRequest(exp.Message);
            }
        }

        /// <summary>
        /// Update order details
        /// </summary>
        [HttpPut]
        public async Task<ActionResult> UpdateAsync(OrderModelIn item)
        {
            try
            {
                await ser.UpdateAsync(item);
                return Ok(item);
            }
            catch (Exception exp )
            {
                return BadRequest(exp.Message);
            }
        }

        /// <summary>
        /// Update status of order
        /// </summary>
        [HttpPost]
        [Route("UpdateStatus")]
        public async Task<ActionResult> UpdateStatus(UpdateStatusModelIn ord)
        {
            try
            {
                await ser.UpdateStatus(ord);
                return Ok(ord);

            }
            catch (Exception exp)
            {
                return BadRequest($"{exp.Message}");
            }
        }

        /// <summary>
        ///Get current status of order
        /// </summary>
        [HttpGet]
        [Route("Status/{Id:long}")]
        public async Task<ActionResult> OrderStatus(long  Id)
        {
            try
            {
                var res= await ser.CheckStatus(Id);
                if(string.IsNullOrEmpty(res))
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
    }
}
