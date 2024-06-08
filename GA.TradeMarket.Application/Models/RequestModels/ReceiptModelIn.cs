namespace GA.TradeMarket.Application.Models.RequestModels
{
    public class ReceiptModelIn:AbstractModel
    {
        public long OrderId { get; set; }

        public long CustomerId { get; set; }

        public bool IsCheckedOut { get; set; }
    }
}
