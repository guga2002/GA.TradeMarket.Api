namespace GA.TradeMarket.Application.Models.RequestModels
{
    public class WishListModelIn
    {
        public long productId { get; set; }
        public long CustomerId { get; set; }
        public DateTime DateOfLastModification { get; set; }

    }
}
