namespace GA.TradeMarket.Application.Models
{
    public class CustomerActivityModel : AbstractModel
    {
        public long CustomerId { get; set; }

        public string? CustomerName { get; set; }

        public decimal ReceiptSum { get; set; }
    }

}
