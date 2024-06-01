using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA.TradeMarket.Application.Models
{
    public class PasswordResetModel
    {
        [Required(ErrorMessage = "Old Password is required")]
        public required string OldPassword { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public required string NewPassword { get; set; }
    }
}
