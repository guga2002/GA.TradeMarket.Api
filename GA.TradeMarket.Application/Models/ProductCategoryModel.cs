using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA.TradeMarket.Application.Models
{
    public class ProductCategoryModel : AbstractModel
    {
        [RegularExpression("^[A-Z][a-zA-Z]*([ -][A-Z][a-zA-Z]*)*$", ErrorMessage = "THe customer  name is not correct")]
        public string? CategoryName { get; set; }
        public virtual IEnumerable<ProductModel> Products { get; set; }
    }

}
