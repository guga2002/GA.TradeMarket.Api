using System.ComponentModel.DataAnnotations;

namespace GA.TradeMarket.Application.Models
{
    public class CustomerActivityModel : AbstractModel
    {
        public long CustomerId { get; set; }

        [RegularExpression("^[A-Z][a-zA-Z]*([ -][A-Z][a-zA-Z]{3,25})$", ErrorMessage = "The customer  name is not correct")]
        public string? CustomerName { get; set; }

        public decimal ReceiptSum { get; set; }
    }

}
