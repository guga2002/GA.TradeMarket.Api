using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GA.TradeMarket.Domain.Entitites
{
    [Table("ExchangeRates")]
    public class ExchangeRate:AbstractEntity
    {
        [MaxLength(100)]
        public string Currency { get; set; }

        [Range(0,1000)]
        public decimal Buy { get; set; }

        [Range(0,1000)]
        public decimal Sell { get; set; }

        public DateTime LogTime { get; set; }
    }
}
