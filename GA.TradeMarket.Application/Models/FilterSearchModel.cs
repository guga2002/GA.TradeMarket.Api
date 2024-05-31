using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA.TradeMarket.Application.Models
{
    public class FilterSearchModel
    {
        public long? CategoryId { get; set; }
        public int? MinPrice { get; set; }
        public int? MaxPrice { get; set; }

    }
}
