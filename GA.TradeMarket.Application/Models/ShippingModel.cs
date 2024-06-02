using GA.TradeMarket.Domain.Entitites;

namespace GA.TradeMarket.Application.Models
{
    public class ShippingModel:AbstractModel
    {
        public long OrderId { get; set; }
        public string TrackingNumber { get; set; }
        public string Carrier { get; set; }
        public DateTime ShippingDate { get; set; }
        public string Status { get; set; }
        public virtual OrderModel Order { get; set; }
    }
}
