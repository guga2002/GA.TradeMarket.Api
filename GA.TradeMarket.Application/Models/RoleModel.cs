using System.ComponentModel.DataAnnotations;

namespace GA.TradeMarket.Application.Models
{
    public class RoleModel
    {
        [Required(ErrorMessage = "the field is required")]
        public required string Name { get; set; }


        [Required(ErrorMessage = "the field is required")]
        public required string NormalizedName { get; set; }
    }
}
