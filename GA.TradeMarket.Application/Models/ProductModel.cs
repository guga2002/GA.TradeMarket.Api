using System.ComponentModel.DataAnnotations;

namespace GA.TradeMarket.Application.Models
{
    public class ProductModel : AbstractModel
    {
        [RegularExpression("^[A-Z][a-zA-Z]*([ -][A-Z][a-zA-Z]{3,25})$", ErrorMessage = "product name is not correct")]
        public string? ProductName { get; set; }


        public long ProductCategoryId { get; set; }


        [Range(0, int.MaxValue,ErrorMessage ="Amount is out of range")]
        public decimal Price { get; set; }
    }

}
