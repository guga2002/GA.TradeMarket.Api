using GA.TradeMarket.Application.Models;
using GA.TradeMarket.Application.Models.RequestModels;

namespace GA.TradeMarket.Application.Interfaces
{
    public interface IReceiptService : Icrud<ReceiptModel,ReceiptModelIn>
    {
        Task<decimal> ToPayAsync(long id);
        Task RemoveProductAsync(long productId, long id, int quantity);
        Task CheckOutAsync(long id);
        Task AddProductAsync(long productId, long receiptId, int quantity);
        Task<IEnumerable<ReceiptDetailModel>> GetReceiptDetailsAsync(long id);
        Task<IEnumerable<ReceiptModel>> GetReceiptsByPeriodAsync(DateTime start, DateTime end);
        Task<decimal> GetReceiptSum(long id);
        Task<IEnumerable<ReceiptModel>> GetAllReceiptsForCurrentUser(string userName);
    }

}
