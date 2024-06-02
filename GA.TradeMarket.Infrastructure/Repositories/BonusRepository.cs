using GA.TradeMarket.Domain.Data;
using GA.TradeMarket.Domain.Entitites;
using GA.TradeMarket.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace GA.TradeMarket.Infrastructure.Repositories
{
    public class BonusRepository : BaseRepository<BonusProgram>, IBonusProgramRepository
    {
        public BonusRepository(TradeMarketDbContext context) : base(context)
        {
        }

        public async Task AddAsync(BonusProgram bonus)
        {
            if (bonus.Customer is not null)
            {
                if (!await dbset.AnyAsync(io => io.CustomerId == bonus.CustomerId))
                {
                    await dbset.AddAsync(bonus);
                    await context.SaveChangesAsync();
                }
            }
        }

        public async Task DeleteByIdAsync(long Id)
        {
            var res = await dbset.FirstOrDefaultAsync(io => io.Id == Id);
            if (res is not null)
            {
                dbset.Remove(res);
                await context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<BonusProgram>> GetAllAsync()
        {

            return await dbset.ToListAsync();
        }

        public async Task<IEnumerable<BonusProgram>> GetAllWithDetailsAsync()
        {
            return await dbset.Include(io => io.Customer)
                .ThenInclude(io=>io.Reviews)
             
                .ToListAsync();
        }

        public async Task<BonusProgram> GetByIdAsync(long Id)
        {
            var res = await dbset.FirstOrDefaultAsync(io => io.Id == Id);
            if (res is not null)
            {
                return res;
            }
            throw new ArgumentException("No entity found on this ID");
        }

        public async Task<BonusProgram> GetByIdWithDetailsAsync(long Id)
        {
            var res = await dbset.Include(io => io.Customer)
                .ThenInclude(io=>io.bonuses).FirstOrDefaultAsync(io => io.Id == Id);
            if (res != null)
            {
                return res;
            }
            throw new ArgumentException($"No Entity found on this id {Id}");
        }

        public void Update(BonusProgram custom)
        {
            if (dbset.Any(io => io.Id == custom.Id))
            {
                dbset.Update(custom);
                context.SaveChanges();
            }
        }
    }
}
