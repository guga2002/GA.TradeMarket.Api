using GA.TradeMarket.Domain.Data;
using GA.TradeMarket.Domain.Entitites;
using GA.TradeMarket.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace GA.TradeMarket.Infrastructure.Repositories
{
    public class ExchangeRateRepository : BaseRepository<ExchangeRate>, IExchangeRateRepository
    {
        public ExchangeRateRepository(TradeMarketDbContext context) : base(context)
        {
        }

        public async Task AddAsync(ExchangeRate customer)
        {
            if (await dbset.AnyAsync(io => io.Currency.ToLower() == customer.Currency.ToLower() && io.LogTime.Day == DateTime.Now.Day))
            {
                //entity already exist
            }
            else
            {
                await context.AddAsync(customer);
                await context.SaveChangesAsync();
            }
        }

        public async Task DeleteByIdAsync(long Id)
        {
            var res = await dbset.FindAsync(Id);
            if(res is not null)
            {
                dbset.Remove(res);  
                await context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<ExchangeRate>> GetAllAsync()
        {
            return await dbset.ToListAsync();
        }

        public async Task<IEnumerable<ExchangeRate>> GetAllWithDetailsAsync()
        {
            return await dbset.ToListAsync();
        }

        public async Task<ExchangeRate> GetByIdAsync(long Id)
        {
            var res = await dbset.FindAsync(Id);
            return res;
        }

        public async Task<ExchangeRate> GetByIdWithDetailsAsync(long Id)
        {
            var res = await dbset.FindAsync(Id);
            return res;
        }

        public async Task<ExchangeRate> GetByName(string name)
        {
            return await dbset.FirstOrDefaultAsync(io => io.Currency == name);
        }

        public void Update(ExchangeRate custom)
        {
            dbset.Update(custom);
            context.SaveChanges();
        }
    }
}
