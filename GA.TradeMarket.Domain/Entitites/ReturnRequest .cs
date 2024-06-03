using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GA.TradeMarket.Domain.Entitites
{
    [Table("ReturnRequests")]
    public class ReturnRequest : AbstractEntity
    {
        [ForeignKey("Order")]
        public long OrderId { get; set; }

        public DateTime RequestDate { get; set; }

        public string Reason { get; set; }

        [MaxLength(100)]
        public string Status { get; set; }

        public virtual Order Order { get; set; }
    }

}
