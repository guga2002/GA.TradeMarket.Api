using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA.TradeMarket.Application.Models
{
    public class ProductCategoryModel : AbstractModel
    {
        public string? CategoryName { get; set; }
        public List<long>? ProductIds { get; set; }
    }

}
