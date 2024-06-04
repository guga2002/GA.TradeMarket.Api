using System.ComponentModel.DataAnnotations;

namespace GA.TradeMarket.Application.Models
{
    public class PersonModel
    {

        [RegularExpression("^[A-Z][a-zA-Z]{2,15}$", ErrorMessage = "The customer  name is not correct")]
        public string? Name { get; set; }
        [RegularExpression("^[A-Z][a-zA-Z]{3,15}$", ErrorMessage = "The customer  Surname is not correct")]
        public string? Surname { get; set; }
        public DateTime BirthDate { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        public string UserName { get; set; }

        [Phone]
        public string PhoneNumber { get; set; }
    }
}
