namespace GA.TradeMarket.Application.Models
{
    public class FilterSearchModel
    {
        public long? CategoryId { get; set; }
        public int? MinPrice { get; set; }
        public int? MaxPrice { get; set; }

    }
}
