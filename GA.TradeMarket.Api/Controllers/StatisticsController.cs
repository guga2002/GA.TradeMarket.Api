using GA.TradeMarket.Application.Interfaces;
using GA.TradeMarket.Application.Models;
using GA.TradeMarket.Application.StaticFIles;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GA.TradeMarket.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class StatisticsController : ControllerBase
    {

        private readonly IStatisticService statistik;

        public StatisticsController(IStatisticService ser)
        {
            statistik = ser;
        }

        [HttpGet(nameof(GetPopularProducts))]
        public async Task<ActionResult<IEnumerable<ProductModel>>> GetPopularProducts([FromQuery]int productCount)
        {
            var res = await statistik.GetMostPopularProductsAsync(productCount);
            if (res == null)
            {
               return BadRequest(ErrorKeys.BadRequest);
            }
            return Ok(res);
        }

        [HttpGet("customer/{id:long}/{productCount:int}")]
        public async Task<ActionResult<IEnumerable<ProductModel>>> GetCustomerFavoriteProducts([FromQuery]int productCount,[FromRoute] long customerId)
        {

            var res = await statistik.GetCustomersMostPopularProductsAsync(productCount, customerId);
            if (res == null)
            {
               return BadRequest(ErrorKeys.BadRequest);
            }
            return Ok(res);
        }

        [HttpGet("activity/{customerCount:int}")]
        public async Task<ActionResult<IEnumerable<CustomerModel>>> GetMostActiveCustomers([FromRoute]int customerCount, DateTime startDate, DateTime endDate)
        {
            var res = await statistik.GetMostValuableCustomersAsync(customerCount, startDate, endDate);
            if (res == null)
            {
                return BadRequest(ErrorKeys.BadRequest);
            }
            return Ok(res);
        }

        [HttpGet("income/{categoryId:long}")]
        public async Task<ActionResult<decimal>> GetCategoryIncome(long categoryId, DateTime startDate, DateTime endDate)
        {
            var res = await statistik.GetIncomeOfCategoryInPeriod(categoryId, startDate, endDate);
            return Ok(res);
        }

    }
}
