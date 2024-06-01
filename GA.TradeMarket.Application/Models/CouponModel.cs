namespace GA.TradeMarket.Application.Models
{
    public class CouponModel
    {
        public string Code { get; set; }
        public decimal DiscountValue { get; set; }
        public DateTime ExpiryDate { get; set; }
    }
}
