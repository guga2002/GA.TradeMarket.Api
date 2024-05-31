
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA.TradeMarket.Domain.Entitites
{
    [Table("Persons")]
    public class Person:Microsoft.AspNetCore.Identity.IdentityUser
    {
        public string? Name { get; set; }

        public string? Surname { get; set; }

        public DateTime BirthDate { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
