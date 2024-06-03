using System.ComponentModel.DataAnnotations;

namespace GA.TradeMarket.Application.Models
{
    public class PaymentMethodModel:AbstractModel
    {
        public string CardNumber { get; set; }

        [RegularExpression("^[A-Z][a-zA-Z]*([ -][A-Z][a-zA-Z]*)*$", ErrorMessage = "Card Holder Name is not in correct format,")]
        public string CardHolderName { get; set; }

        public DateTime ExpiryDate { get; set; }

        [StringLength(3,ErrorMessage ="Cvv must be  exactly 3 digit",MinimumLength =3)]
        public string CVV { get; set; }

        public virtual IEnumerable<PaymentModel> Payments { get; set; }
    }
}
