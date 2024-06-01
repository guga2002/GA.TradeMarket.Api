namespace GA.TradeMarket.Application.Models
{
    public class ReturnRequestModel:AbstractModel
    {
        public long OrderId { get; set; }
        public DateTime RequestDate { get; set; }
        public string Reason { get; set; }
        public string Status { get; set; }
    }
}
