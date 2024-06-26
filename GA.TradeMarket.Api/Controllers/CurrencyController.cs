﻿using GA.TradeMarket.Application.Interfaces;
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
        /// Converts currencies using the source from TBC bank.
        /// </summary>
        /// <remarks>
        /// This endpoint is accessible to anonymous users.
        /// </remarks>
        /// <param name="mod">The conversion model containing the currency details.</param>
        /// <returns>Returns the exchange rate data.</returns>
        [HttpPost]
        [Route(nameof(ConvertNow))]
        [AllowAnonymous]
        public async Task<ActionResult<ExchangeRateDecodable>> ConvertNow([FromBody] ConvertCurrencyModel mod)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ErrorKeys.General);
            }
            var res = await ser.ConvertNow(mod);
            return Ok(res);
        }

        /// <summary>
        /// Gets the exchange rate for a specified currency from the database.
        /// </summary>
        /// <remarks>
        /// This endpoint is accessible to anonymous users.
        /// </remarks>
        /// <param name="Currency">The currency code (alpha).</param>
        /// <returns>Returns the exchange rate as a string.</returns>
        [HttpPost]
        [Route("{Currency:alpha}")]
        [AllowAnonymous]
        public async Task<ActionResult<string>> GetExchangeRate([FromRoute] string Currency)
        {

            var res = await ser.Getcourse(Currency);
            if (res is null)
            {
                return NotFound(res);
            }
            return Ok(res);
        }

        /// <summary>
        /// Gets all exchange rates from the database.
        /// </summary>
        /// <remarks>
        /// This endpoint is accessible to users with the roles "customer", "operator", "manager", and "admin".
        /// </remarks>
        /// <returns>Returns a list of exchange rate models.</returns>
        [HttpGet]
        [Authorize(Roles = "customer,operator,manager,admin")]
        public async Task<ActionResult<ExchangeRateModel>> GetExchangeRates()
        {
            var res = await ser.GetExchangeRates();
            if (!res.Any())
            {
                return NotFound(ErrorKeys.NotFound);
            }
            return Ok(res);
        }

        /// <summary>
        /// Removes a specified currency from the database.
        /// </summary>
        /// <remarks>
        /// This endpoint is accessible to users with the role "manager".
        /// </remarks>
        /// <param name="id">The Id of the currency to remove.</param>
        /// <returns>Returns the Id of the removed currency.</returns>
        [HttpDelete]
        [Route("{id:long}")]
        [Authorize(Roles = "manager")]
        public async Task<ActionResult> Delete([FromRoute] long id)
        {
            await ser.Delete(id);
            return Ok(id);
        }
    }
}
