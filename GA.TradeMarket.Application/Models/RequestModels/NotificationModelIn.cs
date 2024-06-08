namespace GA.TradeMarket.Application.Models.RequestModels
{
    public class NotificationModelIn
    {
        public long UserId { get; set; }
        public string Message { get; set; }
        public DateTime NotificationDate { get; set; }
        public bool IsSeen { get; set; } = false;
    }
}
