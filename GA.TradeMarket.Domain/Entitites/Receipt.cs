using System.ComponentModel.DataAnnotations.Schema;

namespace GA.TradeMarket.Domain.Entitites
{
    [Table("Receipts")]
    public class Receipt : AbstractEntity
    {
        [ForeignKey("order")]
        public long OrderId { get; set; }

        public bool IsCheckedOut { get; set; }

        public virtual Order order { get; set; }
        public virtual  IEnumerable<ReceiptDetail> ReceiptDetails { get; set; }
    }

}
