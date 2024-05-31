using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA.TradeMarket.Application.Models
{
    public class CustomerActivityModel
    {
        public long CustomerId { get; set; }

        public string? CustomerName { get; set; }

        public decimal ReceiptSum { get; set; }
    }

}
