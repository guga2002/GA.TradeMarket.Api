namespace GA.TradeMarket.Application.Models.RequestModels
{
    public class PaymentModelIn:AbstractModel
    {
        public long OrderId { get; set; }

        public long paymentMethodId { get; set; }

        public decimal Amount { get; set; }

        public string PaymentMethod { get; set; }

        public DateTime PaymentDate { get; set; }
    }
}
