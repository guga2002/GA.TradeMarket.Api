using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA.TradeMarket.Application.Models
{
    public class IncomeOfCategoryModel
    {
        public long CategoryId { get; set; }

        public DateTime start { get; set; }

        public DateTime end { get; set; }
    }
}
