using GA.TradeMarket.Application.Models;
using GA.TradeMarket.Application.Models.RequestModels;

namespace GA.TradeMarket.Application.Interfaces
{
    public interface IWishListService:Icrud<WishListModel,WishListModelIn>
    {
        Task<IEnumerable<WishListModel>> GetAllWithDetailsAsync(string username);
    }
}
