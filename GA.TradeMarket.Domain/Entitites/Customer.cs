using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace GA.TradeMarket.Domain.Entitites
{
    [Table("Customers")]
    [Index(nameof(DiscountValue), IsDescending = new bool[] { true })]
    [Index(nameof(OperationDate), IsDescending = new bool[] { true })]
    public class Customer:AbstractEntity
    {
        [ForeignKey("person")]
        public string PersonId { get; set; }

        public decimal DiscountValue { get; set; }

        public DateTime OperationDate { get; set; }

        public virtual Person Person { get; set; }

        public virtual IEnumerable<Order> Orders { get; set; }

        public virtual IEnumerable<BonusProgram> bonuses { get; set; }

        public virtual IEnumerable<Review> Reviews { get; set; }

        public virtual IEnumerable<Notification> Notifications { get; set; }

        public virtual IEnumerable<PaymentMethod> Paymemethods { get; set; }

    }
}
