namespace GA.TradeMarket.Application.Models
{
    public class ShippingStatusUpdateModel
    {
        public required string NewStatus { get; set; }
        public long shippingId { get; set; }
    }
}
