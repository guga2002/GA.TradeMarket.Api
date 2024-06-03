using System.ComponentModel.DataAnnotations;

namespace GA.TradeMarket.Application.Models
{
    public class ReceiptDetailModel : AbstractModel
    {
        public long ReceiptId { get; set; }

        public long ProductId { get; set; }

        [Range(0, int.MaxValue,ErrorMessage ="Total amount is not in correct format")]
        public decimal UnitPrice { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "DiscountUnite amount is not in correct format")]
        public decimal DiscountUnitPrice { get; set; }

        [Range(0,1000,ErrorMessage ="Quantity is not correct")]
        public int Quantity { get; set; }

        public virtual ProductModel Product { get; set; }
    }

}
