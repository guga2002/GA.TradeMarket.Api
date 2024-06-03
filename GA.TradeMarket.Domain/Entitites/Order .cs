using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GA.TradeMarket.Domain.Entitites
{
    [Table("Orders")]
    [Index(nameof(OrderDate), IsDescending = new bool[] { true })]
    public class Order : AbstractEntity
    {
        [ForeignKey("Customer")]
        public long CustomerId { get; set; }

        public DateTime OrderDate { get; set; }

        [MaxLength(40)]
        public string Status { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual IEnumerable<Payment> payments { get; set; }

        public virtual ReturnRequest ReturnRequest{ get; set; }

        public virtual Shipping Shipping { get; set; }

        public virtual IEnumerable<Receipt> Receipts { get; set; }
    }
}
