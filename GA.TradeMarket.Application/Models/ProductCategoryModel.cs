using System.ComponentModel.DataAnnotations;

namespace GA.TradeMarket.Application.Models
{
    public class ProductCategoryModel : AbstractModel
    {
        [RegularExpression("^[A-Z][a-zA-Z]*([ -][A-Z][a-zA-Z]{3,25})$", ErrorMessage = "THe customer  name is not correct")]
        public string? CategoryName { get; set; }

        public virtual IEnumerable<ProductModel> Products { get; set; }
    }

}
