namespace GA.TradeMarket.Application.Models.RequestModels
{
    public class OrderModelIn:AbstractModel
    {
        public long CustomerId { get; set; }
        public DateTime OrderDate { get; set; }
        public string Status { get; set; }
    }
}
