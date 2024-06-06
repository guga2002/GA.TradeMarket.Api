namespace GA.TradeMarket.Application.Models
{
    public class CustomerModel
    {
        public long Id { get; set; }

        public string PersonId { get; set; }

        public int DiscountValue { get; set; }

        public decimal ReceiptSum { get; set; }

        public virtual PersonModel Person { get; set; }

        public virtual IEnumerable<OrderModel> Orders { get; set; }

    }

}
