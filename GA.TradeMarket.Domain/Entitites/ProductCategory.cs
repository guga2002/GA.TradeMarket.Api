using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA.TradeMarket.Domain.Entitites
{
    [Table("ProductCategories")]
    [Index(nameof(CategoryName), IsDescending = new bool[] { true })]
    public class ProductCategory : AbstractEntity
    {
        public required string CategoryName { get; set; }

        public virtual IEnumerable<Product> Products { get; set; }
    }

}
