namespace GA.TradeMarket.Application.Models
{
    public class BonusProgramModel:AbstractModel
    {
        public long CustomerId { get; set; }
        public int Points { get; set; }
        public DateTime EnrollmentDate { get; set; }
    }
}
