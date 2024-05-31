using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public required string ProductName { get; set; }

        public decimal Price { get; set; }

        public virtual ProductCategory Category { get; set; }

        public virtual List<ReceiptDetail>? ReceiptDetails { get; set; }
    }

}
