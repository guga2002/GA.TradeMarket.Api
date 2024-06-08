using GA.TradeMarket.Application.Interfaces;
using GA.TradeMarket.Application.Models;
using GA.TradeMarket.Application.Models.DecoderObjects;
using GA.TradeMarket.Application.StaticFIles;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GA.TradeMarket.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public sealed class CurrencyController : ControllerBase
    {
        private readonly ICurrencyService ser;
        private readonly ILogger<CurrencyController> logger;

        public CurrencyController(ICurrencyService ser, ILogger<CurrencyController> logger)
        {
            this.ser = ser;
            this.logger = logger;
        }

        /// <summary>
        /// Converting currencies, source from TBC bank, allow anymous access
        /// </summary>
        [HttpPost]
        [Route(nameof(ConvertNow))]
        [AllowAnonymous]
        public async Task<ActionResult<ExchangeRateDecodable>> ConvertNow([FromBody]ConvertCurrencyModel mod)
        {
            try
            {
                if(!ModelState.IsValid)
                {
                    return BadRequest(ErrorKeys.General);
                }
                var res = await ser.ConvertNow(mod);
                return Ok(res);
            }
            catch (Exception exp)
            {
                logger.LogError($"error ocured while send request to server, for fetch data{exp.Message}");
                return BadRequest(exp.Message);
            }
        }

        /// <summary>
        /// Getting exchange rate, from DB, anyone can access it
        /// </summary>
        [HttpPost]
        [Route("{Currency:alpha}")]
        [AllowAnonymous]
        public async Task<ActionResult<string>> GetExchangeRate([FromRoute]string Currency)
        {
            try
            {
               var res=await ser.Getcourse(Currency);
                if(res is null)
                {
                    return NotFound(res);
                }
                return Ok(res);
            }
            catch (Exception ex)
            {
                logger.LogError($"error ocured while send request to server, for fetch data{ex.Message}");
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// all exchange rates allowed -- customer, operator,manager,admin
        /// </summary>
        [HttpGet]
        [Authorize("customer,operator,manager,admin")]
        public async Task<ActionResult<ExchangeRateModel>> GetExchangeRates()
        {
            try
            {
                var res= await ser.GetExchangeRates();
                if(!res.Any())
                {
                    return NotFound(ErrorKeys.NotFound);
                }
                return Ok(res);
            }
            catch (Exception exp)
            {
                logger.LogCritical($"Error, while user trying fetch data to server{exp.Message}");
                return BadRequest(exp.Message);
            }
        }

        /// <summary>
        /// remove specify currency from DB -- allowed manager
        /// </summary>
        [HttpDelete]
        [Route("{id:long}")]
        [Authorize("manager")]
        public async Task<ActionResult> Delete([FromRoute]long id)
        {
            try
            {
                await ser.Delete(id);
                return Ok(id);
            }
            catch (Exception exp)
            {
                logger.LogError($"Error while delete  currency from server{exp.Message}");
                return BadRequest(exp.Message);
            }
        }
    }
}
