using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA.TradeMarket.Application.Models
{
    public class ProductModel : AbstractModel
    {
        public string? ProductName { get; set; }

        public long ProductCategoryId { get; set; }

        public string? CategoryName { get; set; }

        public decimal Price { get; set; }

        public List<long>? ReceiptDetailIds { get; set; }
    }

}
