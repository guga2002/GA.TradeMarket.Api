using System.ComponentModel.DataAnnotations.Schema;

namespace GA.TradeMarket.Domain.Entitites
{
    [Table("Payments")]
    public class Payment : AbstractEntity
    {
        [ForeignKey("Order")]
        public long OrderId { get; set; }
        [ForeignKey("method")]
        public long paymentMethodId { get; set; }
        public decimal Amount { get; set; }
        public string PaymentMethod { get; set; }
        public DateTime PaymentDate { get; set; }
        public virtual Order Order { get; set; }
        public virtual PaymentMethod method { get; set; }
    }
}
