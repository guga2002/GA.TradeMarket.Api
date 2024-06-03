namespace GA.TradeMarket.Application.Models
{
    public class ProductModel : AbstractModel
    {
        public string? ProductName { get; set; }

        public long ProductCategoryId { get; set; }

        public decimal Price { get; set; }
    }

}
