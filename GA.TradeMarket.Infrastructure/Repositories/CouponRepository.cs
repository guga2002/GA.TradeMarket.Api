using GA.TradeMarket.Domain.Data;
using GA.TradeMarket.Domain.Entitites;
using GA.TradeMarket.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace GA.TradeMarket.Infrastructure.Repositories
{
    public class CouponRepository : BaseRepository<Coupon>, ICouponRepository
    {
        public CouponRepository(TradeMarketDbContext context) : base(context)
        {
        }

        public async Task AddAsync(Coupon coupon)
        {
            if (coupon.Code is not null)
            {
                if (!await dbset.AnyAsync(io => io.Code == coupon.Code))
                {
                    await dbset.AddAsync(coupon);
                    await context.SaveChangesAsync();
                }
            }
        }

        public async Task DeleteByIdAsync(long Id)
        {
            var res = await dbset.FindAsync(Id);
            if (res is not null)
            {
                dbset.Remove(res);
                await context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Coupon>> GetAllAsync()
        {

            return await dbset.ToListAsync();
        }

        public async Task<IEnumerable<Coupon>> GetAllWithDetailsAsync()
        {
            return await dbset.ToListAsync();
        }

        public async Task<Coupon> GetByIdAsync(long Id)
        {
            var res = await dbset.FirstOrDefaultAsync(io => io.Id == Id);
            if (res is not null)
            {
                return res;
            }
            throw new ArgumentException("No entity found on this ID");
        }

        public async Task<Coupon> GetByIdWithDetailsAsync(long Id)
        {
            var res = await dbset.FirstOrDefaultAsync(io => io.Id == Id);
            if (res != null)
            {
                return res;
            }
            throw new ArgumentException($"No Entity found on this id {Id}");
        }

        public void Update(Coupon coupon)
        {
            if (dbset.Any(io => io.Id == coupon.Id))
            {
                dbset.Update(coupon);
                context.SaveChanges();
            }
        }
    }
}
