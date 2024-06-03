using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GA.TradeMarket.Domain.Entitites
{
    [Table("Reviews")]
    public class Review : AbstractEntity
    {
        [ForeignKey("Product")]
        public long ProductId { get; set; }

        [ForeignKey("Customer")]
        public long CustomerId { get; set; }

        public string ReviewText { get; set; }

        [Range(0,10)]
        public int Rating { get; set; }

        public DateTime ReviewDate { get; set; }

        public virtual Product Product { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
