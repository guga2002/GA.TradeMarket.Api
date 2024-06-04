using System.ComponentModel.DataAnnotations;

namespace GA.TradeMarket.Application.Models
{
    public class PaymentModel:AbstractModel
    {
        public long OrderId { get; set; }

        public long paymentMethodId { get; set; }

        [Range(0,int.MaxValue,ErrorMessage ="The argument is not in correct range, Amount")]
        public decimal Amount { get; set; }

        [RegularExpression("^[A-Z][a-zA-Z]*([ -][A-Z][a-zA-Z]{3,30}})$", ErrorMessage = "PaymentMethod is not in correct format")]
        public string PaymentMethod { get; set; }

        public DateTime PaymentDate { get; set; }

        public virtual OrderModel Order { get; set; }
    }
}
