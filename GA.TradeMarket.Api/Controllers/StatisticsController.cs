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

        /// <summary>
        /// get specify  counted  popular shipper in data range
        /// </summary>
        [HttpPost]
        [Route(nameof(PopularShiper))]
        public async Task<ActionResult> PopularShiper(StatisticShipperModel mod)
        {
            try
            {
                var res=await statistik.PopularShiper(mod);
                if(res.Any())
                {
                    return Ok(res);
                }
                return NotFound(ErrorKeys.NotFound);
            }
            catch (Exception exp)
            {
                return BadRequest(exp.Message);
            }

        }

        /// <summary>
        /// get  popular products by specify count
        /// </summary>
        [HttpGet(nameof(GetPopularProducts))]
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
                return BadRequest($"{exp.Message}");
            }
        }

        /// <summary>
        /// get  customer facorite products
        /// </summary>
        [HttpGet("customer/{id:long}/{productCount:int}")]
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
                return BadRequest(exp.Message);
            }
        }

        /// <summary>
        /// get most active customers
        /// </summary>
        [HttpPost]
        [Route(nameof(MostActiveCustomers))]
        public async Task<ActionResult<IEnumerable<CustomerModel>>> MostActiveCustomers([FromBody]StatisticShipperModel Customer)
        {
            try
            {
                var res = await statistik.GetMostValuableCustomersAsync(Customer);
                if (res == null)
                {
                    return BadRequest(ErrorKeys.BadRequest);
                }
                return Ok(res);
            }
            catch (Exception exp)
            {
                return BadRequest(exp.Message);
            }
        }

        /// <summary>
        /// get incomes by category id
        /// </summary>
        [HttpPost]
        [Route(nameof(CategoryIncome))]
        public async Task<ActionResult<decimal>> CategoryIncome([FromBody] IncomeOfCategoryModel Statistic)
        {
            try
            {
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
