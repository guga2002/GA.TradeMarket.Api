using System.ComponentModel.DataAnnotations.Schema;

namespace GA.TradeMarket.Domain.Entitites
{
    public class BonusProgram
    {
        [ForeignKey("Customer")]
        public long CustomerId { get; set; }
        public int Points { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
