using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GA.TradeMarket.Domain.Entitites
{
    [Table("PaymentMethods")]
    public class PaymentMethod : AbstractEntity
    {
        [MaxLength(50)]
        public string CardNumber { get; set; }

        [MaxLength(50)]
        public string CardHolderName { get; set; }

        public DateTime ExpiryDate { get; set; }

        [MaxLength(4)]
        public string CVV { get; set; }

        public virtual IEnumerable<Payment> Payments { get; set; }
    }
}
