using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA.TradeMarket.Application.Models
{
    public class AbstractModel
    {
        public long Id { get; set; }
        public AbstractModel()
        {
        }
        public AbstractModel(long a)
        {
            this.Id = a;
        }
    }

}
