using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA.TradeMarket.Application.Models
{
    public class CustomerModel
    {
        public string id { get; set; }

        public string? Name { get; set; }

        public string? Surname { get; set; }

        public DateTime BirthDate { get; set; }

        public int DiscountValue { get; set; }

        public List<long>? ReceiptsIds { get; set; }

        public decimal ReceiptSum { get; set; }
    }

}
