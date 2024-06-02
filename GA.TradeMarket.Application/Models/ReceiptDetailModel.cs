using GA.TradeMarket.Domain.Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA.TradeMarket.Application.Models
{
    public class ReceiptDetailModel : AbstractModel
    {
        public long ReceiptId { get; set; }

        public long ProductId { get; set; }

        public decimal UnitPrice { get; set; }

        public decimal DiscountUnitPrice { get; set; }

        public int Quantity { get; set; }

        public virtual ProductModel Product { get; set; }
    }

}
