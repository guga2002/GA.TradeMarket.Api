using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
