using System.ComponentModel.DataAnnotations;

namespace GA.TradeMarket.Application.Models.RequestModels
{
    public class CustomerModelIn
    {
        public long Id { get; set; }

        public string PersonId { get; set; }

        [Range(0, int.MaxValue)]
        public decimal DiscountValue { get; set; }

    }
}
