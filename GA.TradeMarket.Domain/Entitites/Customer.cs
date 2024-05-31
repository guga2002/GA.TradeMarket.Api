using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public virtual IEnumerable<Receipt>? Receipts { get; set; }

    }
}
