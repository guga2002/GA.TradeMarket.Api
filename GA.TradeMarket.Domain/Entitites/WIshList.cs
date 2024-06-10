using System.ComponentModel.DataAnnotations.Schema;

namespace GA.TradeMarket.Domain.Entitites
{
    [Table("Wishlists")]
    public class WIshList:AbstractEntity
    {
        [ForeignKey("product")]
        public long productId { get; set; }

        [ForeignKey("customer")]
        public long CustomerId { get; set; }

        public DateTime DateOfLastModification { get; set; }

        public virtual Product product { get; set; }

        public virtual Customer customer { get; set; }
    }
}
