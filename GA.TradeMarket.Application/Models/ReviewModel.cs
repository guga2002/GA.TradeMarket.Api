namespace GA.TradeMarket.Application.Models
{
    public class ReviewModel:AbstractModel
    {
        public long ProductId { get; set; }
        public long CustomerId { get; set; }
        public string ReviewText { get; set; }
        public int Rating { get; set; }
        public DateTime ReviewDate { get; set; }
    }
}
