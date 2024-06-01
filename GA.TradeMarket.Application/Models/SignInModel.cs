using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA.TradeMarket.Application.Models
{
    public class SignInModel
    {
        public string Email { get; set; }

        public string Password { get; set; }

        public bool SetCookie { get; set; }
    }
}
