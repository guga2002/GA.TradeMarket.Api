using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA.TradeMarket.Application.Models.RequestModels
{
    public class BonusProgramModelIn:AbstractModel
    {
        public long CustomerId { get; set; }
        public int Points { get; set; }
        public DateTime EnrollmentDate { get; set; }
    }
}
