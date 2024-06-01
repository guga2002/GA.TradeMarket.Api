using GA.TradeMarket.Domain.Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA.TradeMarket.Application.Models
{
    public class UserRegistrationModel
    {
        public PersonModel Persons { get; set; }
        public string Password { get; set; }
    }
}
