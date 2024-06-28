using GA.TradeMarket.Application.Interfaces;
using GA.TradeMarket.Application.Models;
using GA.TradeMarket.Application.StaticFIles;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GA.TradeMarket.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatisticsController : ControllerBase
    {

        private readonly IStatisticService statistik;
        private readonly ILogger<StatisticsController> logger;

        public StatisticsController(IStatisticService ser, ILogger<StatisticsController> logger)
        {
            statistik = ser;
            this.logger = logger;
        }

        /// <summary>
        /// Get specify  counted  popular shipper in data range 
        /// </summary>
        /// <remarks>
        /// allow **Manager,operator**
        /// </remarks>
        [HttpPost]
        [Route(nameof(PopularShiper))]
        [Authorize(Roles = "manager,operator")]
        public async Task<ActionResult<ShippingModelStatistic>> PopularShiper([FromBody] StatisticShipperModel mod)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ErrorKeys.InternalServerError);
            }
            var res = await statistik.PopularShiper(mod);
            if (res.Any())
            {
                return Ok(res);
            }
            return NotFound(ErrorKeys.NotFound);
        }

        /// <summary>
        /// Get popular products by specify count 
        /// </summary>
        /// <remarks>
        ///  allow **Manager,operator**
        /// </remarks>
        [HttpGet(nameof(GetPopularProducts))]
        [Authorize(Roles = "operator,manager")]
        public async Task<ActionResult<IEnumerable<ProductModel>>> GetPopularProducts([FromQuery] int productCount)
        {
            var res = await statistik.GetMostPopularProductsAsync(productCount);
            if (res == null)
            {
                return BadRequest(ErrorKeys.BadRequest);
            }
            return Ok(res);
        }

        /// <summary>
        /// Get customer facorite products 
        /// </summary>
        /// <remarks>
        /// allow **Manager,operator**
        /// </remarks>
        [HttpGet("customer/{id:long}/{productCount:int}")]
        [Authorize(Roles = "manager,operator")]
        public async Task<ActionResult<IEnumerable<ProductModel>>> GetCustomerFavoriteProducts([FromRoute] int productCount, [FromRoute] long customerId)
        {
            var res = await statistik.GetCustomersMostPopularProductsAsync(productCount, customerId);
            if (res == null)
            {
                return BadRequest(ErrorKeys.BadRequest);
            }
            return Ok(res);
        }

        /// <summary>
        /// Get most active customers
        /// </summary>
        /// <remarks>
        ///  allow **Manager,operator**
        /// </remarks>
        [HttpPost]
        [Route(nameof(MostActiveCustomers))]
        [Authorize(Roles = "manager,operator")]
        public async Task<ActionResult<IEnumerable<CustomerModel>>> MostActiveCustomers([FromBody] StatisticShipperModel Customer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ErrorKeys.InternalServerError);
            }
            var res = await statistik.GetMostValuableCustomersAsync(Customer);
            if (res == null)
            {
                return BadRequest(ErrorKeys.BadRequest);
            }
            return Ok(res);
        }

        /// <summary>
        /// Get incomes by category id 
        /// </summary>
        /// <remarks>
        /// allow **Manager,operator**
        /// </remarks>
        [HttpPost]
        [Route(nameof(CategoryIncome))]
        [Authorize(Roles = "operator,manager")]
        public async Task<ActionResult<decimal>> CategoryIncome([FromBody] IncomeOfCategoryModel Statistic)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ErrorKeys.InternalServerError);
            }
            var res = await statistik.GetIncomeOfCategoryInPeriod(Statistic);
            if (res == 0)
            {
                return NotFound(ErrorKeys.NotFound);
            }
            return Ok(res);
        }
    }
}
