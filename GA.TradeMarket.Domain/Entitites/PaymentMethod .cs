using System.ComponentModel.DataAnnotations.Schema;

namespace GA.TradeMarket.Domain.Entitites
{
    [Table("PaymentMethods")]
    public class PaymentMethod : AbstractEntity
    {
        public long CustomerId { get; set; }
        public string CardNumber { get; set; }
        public string CardHolderName { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string CVV { get; set; }
        public virtual IEnumerable<Payment> Payments { get; set; }
    }
}
