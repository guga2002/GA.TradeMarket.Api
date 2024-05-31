using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA.TradeMarket.Domain.Entitites
{
    [Table("Receipts")
    [Index(nameof(OperationDate), IsDescending = new bool[] { true })]
    public class Receipt : AbstractEntity
    {
        [ForeignKey("Customer")]
        public long CustomerId { get; set; }

        public DateTime OperationDate { get; set; }

        public bool IsCheckedOut { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual  IEnumerable<ReceiptDetail> ReceiptDetails { get; set; }
    }

}
