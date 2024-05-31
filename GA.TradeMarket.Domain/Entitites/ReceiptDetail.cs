using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA.TradeMarket.Domain.Entitites
{
    [Table("ReceiptDetails")]
    [Index(nameof(UnitPrice), IsDescending = new bool[] { true })]
    [Index(nameof(DiscountUnitPrice), IsDescending = new bool[] { true })]
    [Index(nameof(Quantity), IsDescending = new bool[] { true })]
    public class ReceiptDetail : AbstractEntity
    {
        [ForeignKey("Receipt")]
        public long ReceiptId { get; set; }

        [ForeignKey("Product")]
        public long ProductId { get; set; }

        public decimal UnitPrice { get; set; }

        public decimal DiscountUnitPrice { get; set; }

        public int Quantity { get; set; }

        public virtual Receipt Receipt { get; set; }

        public virtual Product Product { get; set; }
    }

}
