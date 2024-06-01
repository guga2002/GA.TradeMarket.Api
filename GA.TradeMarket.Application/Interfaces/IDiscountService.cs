using GA.TradeMarket.Application.Models;

namespace GA.TradeMarket.Application.Interfaces
{
    public interface IDiscountService:Icrud<BonusProgramModel>
    {
        Task UpdateCouponAsync(CouponModel mod);
        Task RemoveCouponAsync(long a);
        Task AddCouponAsync(CouponModel mod);
        Task<IEnumerable<CouponModel>> GetAllCouponAsync();
    }
}
