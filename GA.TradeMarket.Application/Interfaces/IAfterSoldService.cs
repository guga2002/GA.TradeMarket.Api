using GA.TradeMarket.Application.Models;
using GA.TradeMarket.Domain.Entitites;

namespace GA.TradeMarket.Application.Interfaces
{
    public interface IAfterSoldService:Icrud<ReturnRequestModel>
    {
        Task UpdateReviewAsync(ReviewModel mod);
        Task RemoveReviewAsync(long a);
        Task AddReviewAsync(ReviewModel mod);
        Task<IEnumerable<ReviewModel>> GetAllReviewsAsync();
    }
}
