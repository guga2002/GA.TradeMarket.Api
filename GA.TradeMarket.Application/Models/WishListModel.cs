namespace GA.TradeMarket.Application.Models
{
    public class WishListModel
    {
        public long productId { get; set; }
        public long CustomerId { get; set; }
        public DateTime DateOfLastModification { get; set; }
        public ProductModel Product { get; set; }
    }
}
