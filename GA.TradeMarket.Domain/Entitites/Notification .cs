using System.ComponentModel.DataAnnotations.Schema;

namespace GA.TradeMarket.Domain.Entitites
{
    [Table("Notifications")]
    public class Notification : AbstractEntity
    {
        [ForeignKey("User")]
        public long UserId { get; set; }
        public string Message { get; set; }
        public DateTime NotificationDate { get; set; }
        public virtual Customer User { get; set; }
    }
}
