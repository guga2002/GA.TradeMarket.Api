using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA.TradeMarket.Application.Models
{
    public class ReceiptModel : AbstractModel
    {
        public long CustomerId { get; set; }

        public bool IsCheckedOut { get; set; }

        public DateTime OperationDate { get; set; }

        public List<long>? ReceiptDetailsIds { get; set; }
    }

}
