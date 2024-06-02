using GA.TradeMarket.Application.Models;
using GA.TradeMarket.Application.Models.RequestModels;

namespace GA.TradeMarket.Application.Interfaces
{
    public interface IOrderService:Icrud<OrderModel,OrderModelIn>
    {
    }
}
