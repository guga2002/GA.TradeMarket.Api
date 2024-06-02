using GA.TradeMarket.Domain.Data;
using GA.TradeMarket.Domain.Entitites;
using GA.TradeMarket.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace GA.TradeMarket.Infrastructure.Repositories
{
    public class ReviewRepository : BaseRepository<Review>, IReviewRepository
    {
        public ReviewRepository(TradeMarketDbContext context) : base(context)
        {
        }
        public async Task AddAsync(Review customer)
        {
            if (!await dbset.AnyAsync(io => io.CustomerId == customer.CustomerId&&io.ProductId==customer.ProductId))
            {
                await dbset.AddAsync(customer);
                await context.SaveChangesAsync();
            }
        }

        public async Task DeleteByIdAsync(long Id)
        {
            var res = await dbset.FirstOrDefaultAsync(io => io.Id == Id);
            dbset.Remove(res ?? throw new ArgumentException("No entity found!"));
            await context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Review>> GetAllAsync()
        {
            return await dbset.ToListAsync();
        }

        public async Task<IEnumerable<Review>> GetAllWithDetailsAsync()
        {
            return await dbset
       .Include(r => r.Product)
       .Include(io=>io.Customer)
       .ThenInclude(io => io.Person)
       .ToListAsync();
        }

        public async Task<Review> GetByIdAsync(long Id)
        {
            var res = await dbset.FirstOrDefaultAsync(io => io.Id == Id);
            if (res is not null)
            {
                return res;
            }
            throw new ArgumentException("No relate entity found!");
        }

        public async Task<Review> GetByIdWithDetailsAsync(long Id)
        {
            var res = await dbset
                .Include(r => r.Customer)
               .ThenInclude(rd => rd.bonuses)
              .Where(io => io.Id == Id).FirstOrDefaultAsync();
            if (res is not null)
            {
                return res;
            }
            else
            {
                throw new ArgumentException("No relate entity found!");
            }
        }

        public void Update(Review custom)
        {
            if (dbset.Any(io => io.Id == custom.Id))
            {
                dbset.Update(custom);
                context.SaveChanges();
            }
        }
    }
}
