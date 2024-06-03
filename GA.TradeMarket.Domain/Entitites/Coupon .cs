using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GA.TradeMarket.Domain.Entitites
{
    [Table("Coupons")]
    public class Coupon : AbstractEntity
    {
        public string Code { get; set; }

        [Range(0, int.MaxValue)]
        public decimal DiscountValue { get; set; }

        public DateTime ExpiryDate { get; set; }
    }
}
