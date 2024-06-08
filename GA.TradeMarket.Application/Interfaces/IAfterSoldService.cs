using GA.TradeMarket.Application.Models;
using GA.TradeMarket.Application.Models.RequestModels;

namespace GA.TradeMarket.Application.Interfaces
{
    public interface IAfterSoldService:Icrud<ReturnRequestModel, ReturnRequestModelIn>
    {
        Task UpdateReviewAsync(ReviewModelIn mod);
        Task RemoveReviewAsync(long a);
        Task AddReviewAsync(ReviewModelIn mod);
        Task<IEnumerable<ReviewModel>> GetAllReviewsAsync();
        Task<IEnumerable<ReturnRequestModel>> GetAllMyReturnRequests(string username);
    }
}
