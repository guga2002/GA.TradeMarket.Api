using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

        [Range(0,int.MaxValue)]
        public decimal UnitPrice { get; set; }

        [Range(0, int.MaxValue)]
        public decimal DiscountUnitPrice { get; set; }

        [Range(0,30000)]
        public int Quantity { get; set; }


        public virtual Receipt Receipt { get; set; }


        public virtual Product Product { get; set; }
    }

}
