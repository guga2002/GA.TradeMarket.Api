using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GA.TradeMarket.Domain.Entitites
{
    [Table("Shippings")]
    public class Shipping : AbstractEntity
    {
        [ForeignKey("Order")]
        public long OrderId { get; set; }

        [MaxLength(50)]
        public string TrackingNumber { get; set; }

        [MaxLength(50)]
        public string Carrier { get; set; }

        public DateTime ShippingDate { get; set; }

        [MaxLength(30)]
        public string Status { get; set; }

        public virtual Order Order { get; set; }
    }
}
