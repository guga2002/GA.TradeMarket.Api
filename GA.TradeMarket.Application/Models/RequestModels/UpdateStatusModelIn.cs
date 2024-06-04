namespace GA.TradeMarket.Application.Models.RequestModels
{
    public class UpdateStatusModelIn
    {
        public long OrderId { get; set; }

        public string Status { get; set; }
    }
}
