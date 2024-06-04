using System.ComponentModel.DataAnnotations;

namespace GA.TradeMarket.Application.Models
{
    public class SignInModel
    {
        [StringLength(30,MinimumLength =5,ErrorMessage ="THe length of user is not valid")]
        public string Username { get; set; }


        [StringLength(30,MinimumLength =5,ErrorMessage ="Password is not strong enought")]
        public string Password { get; set; }


        public bool SetCookie { get; set; }
    }
}
