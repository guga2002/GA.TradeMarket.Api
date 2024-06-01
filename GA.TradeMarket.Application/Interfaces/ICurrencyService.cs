using GA.TradeMarket.Application.Models;
using GA.TradeMarket.Application.Models.DecoderObjects;

namespace GA.TradeMarket.Application.Interfaces
{
    public interface ICurrencyService
    {
        Task<ExchangeRateModel> Getcourse(string currency);
        Task<IEnumerable<ExchangeRateModel>> GetExchangeRates();
        Task Delete(long id);
        Task<ExchangeRateDecodable> ConvertNow(ConvertCurrencyModel mod);
    }
}
