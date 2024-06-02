using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA.TradeMarket.Application.Models.RequestModels
{
    public class ProductModelIn:AbstractModel
    {
        public string? ProductName { get; set; }

        public long ProductCategoryId { get; set; }

        public string? CategoryName { get; set; }

        public decimal Price { get; set; }
    }
}
