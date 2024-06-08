using GA.TradeMarket.Application.Models;
using GA.TradeMarket.Application.Models.RequestModels;

namespace GA.TradeMarket.Application.Interfaces
{
    public interface IOrderService:Icrud<OrderModel,OrderModelIn>
    {
        Task<string> CheckStatus(long orderId);
        Task UpdateStatus(UpdateStatusModelIn ord);
        Task<IEnumerable<OrderModel>> GetMyOrder(string username);
    }
}
