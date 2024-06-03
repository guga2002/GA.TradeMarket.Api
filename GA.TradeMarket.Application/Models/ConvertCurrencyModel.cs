using System.ComponentModel.DataAnnotations;

namespace GA.TradeMarket.Application.Models
{
    public class ConvertCurrencyModel
    {
        public decimal Amount { get; set; }

        public string from { get; set; }

        public string to { get; set; }
    }
}
