using System.ComponentModel.DataAnnotations;

namespace GA.TradeMarket.Application.Models
{
    public class UserRegistrationModel
    {
        public PersonModel Persons { get; set; }


        [StringLength(30,MinimumLength =5,ErrorMessage ="Password is not strong enought")]
        public string Password { get; set; }
    }
}
