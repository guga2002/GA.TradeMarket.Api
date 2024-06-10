using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GA.TradeMarket.Domain.Entitites
{
    [Table("Products")]
    [Index(nameof(ProductName), IsDescending = new bool[] { true })]
    [Index(nameof(Price), IsDescending = new bool[] { true })]
    public class Product : AbstractEntity
    {
        [ForeignKey("Category")]
        public long ProductCategoryId { get; set; }

        [Column("ProductName")]
        [MaxLength(100)]
        public required string ProductName { get; set; }

        [Range(0,int.MaxValue)]
        public decimal Price { get; set; }

        public virtual ProductCategory Category { get; set; }

        public virtual IEnumerable<ReceiptDetail> ReceiptDetails { get; set; }

        public virtual IEnumerable<Review> Reviews { get; set; }

        public  virtual IEnumerable<WIshList> WishLists { get; set; }
    }

}
