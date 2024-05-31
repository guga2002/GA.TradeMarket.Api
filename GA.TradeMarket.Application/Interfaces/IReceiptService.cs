using GA.TradeMarket.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA.TradeMarket.Application.Interfaces
{
    public interface IReceiptService : Icrud<ReceiptModel>
    {
        Task<decimal> ToPayAsync(long id);
        Task RemoveProductAsync(long productId, long id, int quantity);
        Task CheckOutAsync(long id);
        Task AddProductAsync(long productId, long receiptId, int quantity);
        Task<IEnumerable<ReceiptDetailModel>> GetReceiptDetailsAsync(long id);
        Task<IEnumerable<ReceiptModel>> GetReceiptsByPeriodAsync(DateTime start, DateTime end);
        Task<decimal> GetReceiptSum(long id);
    }

}
