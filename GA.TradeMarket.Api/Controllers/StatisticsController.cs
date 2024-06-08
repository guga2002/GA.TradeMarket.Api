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
        /// get specify  counted  popular shipper in data range --- allow Manager,operator
        /// </summary>
        [HttpPost]
        [Route(nameof(PopularShiper))]
        [Authorize(Roles ="manager,operator")]
        public async Task<ActionResult<ShippingModelStatistic>> PopularShiper([FromBody]StatisticShipperModel mod)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ErrorKeys.InternalServerError);
                }
                var res=await statistik.PopularShiper(mod);
                if(res.Any())
                {
                    return Ok(res);
                }
                return NotFound(ErrorKeys.NotFound);
            }
            catch (Exception exp)
            {
                logger.LogCritical(exp.Message);
                return BadRequest(exp.StackTrace);
            }

        }

        /// <summary>
        /// get  popular products by specify count  --- allow Manager,operator
        /// </summary>
        [HttpGet(nameof(GetPopularProducts))]
        [Authorize(Roles ="operator,manager")]
        public async Task<ActionResult<IEnumerable<ProductModel>>> GetPopularProducts([FromQuery]int productCount)
        {
            try
            {
                var res = await statistik.GetMostPopularProductsAsync(productCount);
                if (res == null)
                {
                    return BadRequest(ErrorKeys.BadRequest);
                }
                return Ok(res);
            }
            catch (Exception exp)
            {
                logger.LogCritical(exp.Message);
                return BadRequest($"{exp.Message}");
            }
        }

        /// <summary>
        /// get  customer facorite products  --- allow Manager,operator
        /// </summary>
        [HttpGet("customer/{id:long}/{productCount:int}")]
        [Authorize(Roles ="manager,operator")]
        public async Task<ActionResult<IEnumerable<ProductModel>>> GetCustomerFavoriteProducts([FromRoute] int productCount, [FromRoute] long customerId)
        {
            try
            {
                var res = await statistik.GetCustomersMostPopularProductsAsync(productCount, customerId);
                if (res == null)
                {
                    return BadRequest(ErrorKeys.BadRequest);
                }
                return Ok(res);
            }
            catch (Exception exp)
            {
                logger.LogCritical(exp.Message);
                return BadRequest(exp.Message);
            }
        }

        /// <summary>
        /// get most active customers -- allow Manager,operator
        /// </summary>
        [HttpPost]
        [Route(nameof(MostActiveCustomers))]
        [Authorize(Roles ="manager,operator")]
        public async Task<ActionResult<IEnumerable<CustomerModel>>> MostActiveCustomers([FromBody]StatisticShipperModel Customer)
        {
            try
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
            catch (Exception exp)
            {
                logger.LogCritical($"{exp.Message}");
                return BadRequest(exp.Message);
            }
        }

        /// <summary>
        /// get incomes by category id allow Manager,operator
        /// </summary>
        [HttpPost]
        [Route(nameof(CategoryIncome))]
        [Authorize(Roles ="operator,manager")]
        public async Task<ActionResult<decimal>> CategoryIncome([FromBody] IncomeOfCategoryModel Statistic)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ErrorKeys.InternalServerError);
                }
                var res = await statistik.GetIncomeOfCategoryInPeriod(Statistic);
                if(res==0)
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
