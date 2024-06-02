namespace GA.TradeMarket.Application.Models
{
    public class PaymentMethodModel:AbstractModel
    {
        public string CardNumber { get; set; }
        public string CardHolderName { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string CVV { get; set; }
        public virtual IEnumerable<PaymentModel> Payments { get; set; }
    }
}
