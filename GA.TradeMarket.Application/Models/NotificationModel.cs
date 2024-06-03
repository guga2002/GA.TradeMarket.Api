using System.ComponentModel.DataAnnotations;

namespace GA.TradeMarket.Application.Models
{
    public class NotificationModel:AbstractModel
    {
        public long UserId { get; set; }

        [RegularExpression("^[A-Z][a-zA-Z]*([ -][A-Z][a-zA-Z]*)*$", ErrorMessage = "Message is not in correct format,")]
        public string Message { get; set; }
        public DateTime NotificationDate { get; set; }

        public  CustomerModel User { get; set; }
    }
}
