using System.ComponentModel.DataAnnotations.Schema;

namespace GA.TradeMarket.Domain.Entitites
{
    [Table("Shippings")]
    public class Shipping : AbstractEntity
    {
        [ForeignKey("Order")]
        public long OrderId { get; set; }
        public string TrackingNumber { get; set; }
        public string Carrier { get; set; }
        public DateTime ShippingDate { get; set; }
        public string Status { get; set; }
        public virtual Order Order { get; set; }
    }
}
