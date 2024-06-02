namespace GA.TradeMarket.Application.Models
{
    public class ReceiptModel : AbstractModel
    {
        public long CustomerId { get; set; }

        public bool IsCheckedOut { get; set; }

        public virtual IEnumerable<ReceiptDetailModel> ReceiptDetails { get; set; }

    }

}
