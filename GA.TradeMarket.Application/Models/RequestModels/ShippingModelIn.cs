namespace GA.TradeMarket.Application.Models.RequestModels
{
    public class ShippingModelIn:AbstractModel
    {
        public long OrderId { get; set; }
        public string TrackingNumber { get; set; }
        public string Carrier { get; set; }
        public DateTime ShippingDate { get; set; }
        public string Status { get; set; }
    }
}
