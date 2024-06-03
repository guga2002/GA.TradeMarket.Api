using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GA.TradeMarket.Domain.Entitites
{
    public class BonusProgram:AbstractEntity
    {
        [ForeignKey("Customer")]
        public long CustomerId { get; set; }

        [Range(0,360000)]
        public int Points { get; set; }

        public DateTime EnrollmentDate { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
