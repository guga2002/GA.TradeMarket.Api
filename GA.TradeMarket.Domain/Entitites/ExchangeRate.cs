using System.ComponentModel.DataAnnotations.Schema;

namespace GA.TradeMarket.Domain.Entitites
{
    [Table("ExchangeRates")]
    public class ExchangeRate:AbstractEntity
    {
        public string Currency { get; set; }

        public decimal Buy { get; set; }

        public decimal Sell { get; set; }

        public DateTime LogTime { get; set; }
    }
}
