using GA.TradeMarket.Domain.Entitites;

namespace GA.TradeMarket.Application.Models
{
    public class BonusProgramModel:AbstractModel
    {
        public long CustomerId { get; set; }
        public int Points { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public  CustomerModel Customer { get; set; }
    }
}
