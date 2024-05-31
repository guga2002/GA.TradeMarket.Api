using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GA.TradeMarket.Domain.Entitites
{
    [Table("Persons")]
    public class Person: IdentityUser
    {
        public string? Name { get; set; }

        public string? Surname { get; set; }

        public DateTime BirthDate { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
