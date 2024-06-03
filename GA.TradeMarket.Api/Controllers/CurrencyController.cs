using GA.TradeMarket.Application.Interfaces;
using GA.TradeMarket.Application.Models;
using GA.TradeMarket.Application.Models.DecoderObjects;
using GA.TradeMarket.Application.StaticFIles;
using Microsoft.AspNetCore.Mvc;

namespace GA.TradeMarket.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CurrencyController : ControllerBase
    {
        private readonly ICurrencyService ser;

        public CurrencyController(ICurrencyService ser)
        {
                this.ser = ser;
        }

        [HttpPost]
        [Route(nameof(ConvertNow))]
        public async Task<ActionResult<ExchangeRateDecodable>> ConvertNow([FromBody]ConvertCurrencyModel mod)
        {
            try
            {
                var res = await ser.ConvertNow(mod);
                return Ok(res);
            }
            catch (Exception exp)
            {
                return BadRequest(exp.Message);
            }
        }

        [HttpPost]
        [Route("{Currency:alpha}")]
        public async Task<ActionResult<string>> GetValueCourse([FromRoute]string Currency)
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
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
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
                return BadRequest(exp.Message);
            }
        }

        [HttpDelete]
        [Route("{id:long}")]
        public async Task<ActionResult> Delete(long id)
        {
            try
            {
                await ser.Delete(id);
                return Ok(id);
            }
            catch (Exception exp)
            {
                return BadRequest(exp.Message);
            }
        }
    }
}
