using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GA.TradeMarket.Domain.Entitites
{
    [Table("ProductCategories")]
    [Index(nameof(CategoryName), IsDescending = new bool[] { true })]
    public class ProductCategory : AbstractEntity
    {
        [MaxLength(100)]
        public required string CategoryName { get; set; }

        public virtual IEnumerable<Product> Products { get; set; }
    }

}
