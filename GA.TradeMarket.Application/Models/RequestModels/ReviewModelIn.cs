namespace GA.TradeMarket.Application.Models.RequestModels
{
    public class ReviewModelIn:AbstractModel
    {
        public long ProductId { get; set; }
        public long CustomerId { get; set; }
        public string ReviewText { get; set; }
        public int Rating { get; set; }
        public DateTime ReviewDate { get; set; }
    }
}
