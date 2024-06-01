using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA.TradeMarket.Application.Models
{
    public class ExchangeRateModel
    {
        public string Currency { get; set; }

        public decimal Buy { get; set; }

        public decimal Sell { get; set; }

        public DateTime LogTime { get; set; }
    }
}
