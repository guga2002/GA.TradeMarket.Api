using System.ComponentModel.DataAnnotations;

namespace GA.TradeMarket.Application.Models
{
    public class PasswordResetModel
    {
        [Required(ErrorMessage = "Old Password is required")]
        [RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[@$!%*?&])[A-Za-z\\d@$!%*?&]{8,}$",ErrorMessage ="Old password is not in correct format")]
        public required string OldPassword { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[@$!%*?&])[A-Za-z\\d@$!%*?&]{8,}$", ErrorMessage = "New password is not in correct format")]
        public required string NewPassword { get; set; }
    }
}
