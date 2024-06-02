namespace GA.TradeMarket.Application.Models
{
    public class OrderModel:AbstractModel
    {
        public long CustomerId { get; set; }
        public DateTime OrderDate { get; set; }
        public string Status { get; set; }
        public virtual IEnumerable<ReceiptModel> Receipts { get; set; }
    }
}
