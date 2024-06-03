namespace GA.TradeMarket.Application.Models
{
    public class CustomerModel
    {
        public string id { get; set; }

        public int DiscountValue { get; set; }

        public decimal ReceiptSum { get; set; }

        public virtual PersonModel Person { get; set; }

        public virtual IEnumerable<OrderModel> Orders { get; set; }

    }

}
