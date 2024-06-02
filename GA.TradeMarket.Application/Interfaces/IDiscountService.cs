using GA.TradeMarket.Application.Models;
using GA.TradeMarket.Application.Models.RequestModels;

namespace GA.TradeMarket.Application.Interfaces
{
    public interface IDiscountService:Icrud<BonusProgramModel,BonusProgramModelIn>
    {
        Task UpdateCouponAsync(CouponModelIn mod);
        Task RemoveCouponAsync(long a);
        Task AddCouponAsync(CouponModelIn mod);
        Task<IEnumerable<CouponModel>> GetAllCouponAsync();
    }
}
