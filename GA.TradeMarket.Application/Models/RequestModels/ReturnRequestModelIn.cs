using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA.TradeMarket.Application.Models.RequestModels
{
    public class ReturnRequestModelIn:AbstractModel
    {
        public long OrderId { get; set; }
        public DateTime RequestDate { get; set; }
        public string Reason { get; set; }
        public string Status { get; set; }
    }
}
