using GA.TradeMarket.Domain.Data;
using GA.TradeMarket.Domain.Entitites;
using GA.TradeMarket.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace GA.TradeMarket.Infrastructure.Repositories
{
    public class WishListRepository : BaseRepository<WIshList>, IWishListRepository
    {
        public WishListRepository(TradeMarketDbContext context) : base(context)
        {
        }

        public async Task AddAsync(WIshList customer)
        {
            try
            {
                if (await dbset.AnyAsync(io => io.CustomerId == customer.CustomerId && io.productId == customer.productId))
                {
                    throw new ArgumentException("Such product is already in your wishlist");
                }
                await dbset.AddAsync(customer);
                await context.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task DeleteByIdAsync(long Id)
        {
            try
            {
                var res = await dbset.FindAsync(Id);
                if (res is null) throw new ArgumentException($" no related entity found on this ID{Id}");
                dbset.Remove(res);
                await context.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<IEnumerable<WIshList>> GetAllAsync()
        {
            return await dbset.ToListAsync();
        }

        public async Task<IEnumerable<WIshList>> GetAllWithDetailsAsync()
        {
            return await dbset.Include(io => io.product).ToListAsync();
        }

        public async Task<WIshList> GetByIdAsync(long Id)
        {
            var res =await  dbset.FindAsync(Id);
            if(res is not null)
            {
                return res;
            }
            throw new ArgumentException($"No related Entity found on this ID:{Id}");
        }

        public async Task<WIshList> GetByIdWithDetailsAsync(long Id)
        {
            var res = await dbset.Include(io=>io.product).FirstOrDefaultAsync(io=>io.Id==Id);
            if (res is not null)
            {
                return res;
            }
            throw new ArgumentException($"No related Entity found on this ID:{Id}");
        }

        public void Update(WIshList custom)
        {
            try
            {
                var res = dbset.Find(custom.Id);
                if (res is null) throw new ArgumentException("no related entity found");
                res.DateOfLastModification = custom.DateOfLastModification;
                dbset.Update(custom);
                context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
