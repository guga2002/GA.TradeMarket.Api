using AutoMapper;
using GA.TradeMarket.Application.Interfaces;
using GA.TradeMarket.Application.Models;
using GA.TradeMarket.Application.Models.DecoderObjects;
using GA.TradeMarket.Domain.Entitites;
using GA.TradeMarket.Infrastructure.UniteOfWorkRelated;
using System.Net.Http.Headers;
using System.Text.Json;

namespace GA.TradeMarket.Application.Services
{
    public class CurrencyService:AbstractService,ICurrencyService
    {
        public CurrencyService(IUnitOfWork obj, IMapper map) : base(obj, map)
        {
        }

        public async Task Delete(long id)
        {
           await obj.CustomerRepository.DeleteByIdAsync(id);
        }

        public async Task<ExchangeRateModel> Getcourse(string currency)
        {
           var res=await obj.ExchangeRateRepository.GetByName(currency);
            if(res is null)
            {
                var tbcanswer= await GetcourseFromTbc(currency);
                if(tbcanswer.Item1 is null)
                {
                    throw new ArgumentNullException(" bad request no such currency exist");
                }
                var exchangerate = new ExchangeRateModel()
                {
                    Buy = tbcanswer.Item2,
                    Sell = tbcanswer.Item3,
                    Currency = tbcanswer.Item1,
                    LogTime = DateTime.Now
                };
                var mapped=mapper.Map<ExchangeRate>(exchangerate);
                await obj.ExchangeRateRepository.AddAsync(mapped);
                return exchangerate;
            }
            var map = mapper.Map<ExchangeRateModel>(res);
            return map;
        }

        public async Task<IEnumerable<ExchangeRateModel>> GetExchangeRates()
        {
           var res=await obj.ExchangeRateRepository.GetAllAsync();
            var mapped=mapper.Map<IEnumerable<ExchangeRateModel>>(res);
            return mapped;
        }
        
        public async Task<ExchangeRateDecodable> ConvertNow(ConvertCurrencyModel mod)
        {
            var url = $"https://test-api.tbcbank.ge/v1/exchange-rates/commercial/convert?amount={mod.Amount}&from={mod.from.ToLower()}&to={mod.to.ToLower()}";
            using var client = new HttpClient();

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Add("apikey", "I3Rz8QXBVPofKtucsenkW7g2n7aDwqBg");

            HttpResponseMessage response = await client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();
                var result = JsonSerializer.Deserialize<ExchangeRateDecodable>(json);
                return result;
            }
            throw new ArgumentException(" there  was internall error");
        }
        private async Task<(string,decimal,decimal)>  GetcourseFromTbc(string currency)
        {
            var url = $"https://test-api.tbcbank.ge/v1/exchange-rates/commercial?currency={currency}";

            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("apikey", "I3Rz8QXBVPofKtucsenkW7g2n7aDwqBg");

                HttpResponseMessage response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();

                    var result = JsonSerializer.Deserialize<CurrencyData>(content);
                    await Console.Out.WriteLineAsync(result.Base);
                    foreach (var item in result.CommercialRatesList)
                    {
                        return (item.Currency, item.Buy, item.Sell);
                    }
                }     
            }
            return (null, 0, 0);
        }
    }
}
