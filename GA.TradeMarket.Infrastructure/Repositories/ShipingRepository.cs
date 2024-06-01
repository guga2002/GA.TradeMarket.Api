using GA.TradeMarket.Domain.Data;
using GA.TradeMarket.Domain.Entitites;
using GA.TradeMarket.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace GA.TradeMarket.Infrastructure.Repositories
{
    public class ShipingRepository : BaseRepository<Shipping>, IShipingRepository
    {
        public ShipingRepository(TradeMarketDbContext context) : base(context)
        {
        }
        public async Task AddAsync(Shipping customer)
        {
            if (!await dbset.AnyAsync(io => io.TrackingNumber == customer.TrackingNumber))
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

        public async Task<IEnumerable<Shipping>> GetAllAsync()
        {
            return await dbset.ToListAsync();
        }

        public async Task<IEnumerable<Shipping>> GetAllWithDetailsAsync()
        {
            return await dbset
       .Include(r => r.Order)
           .ThenInclude(rd => rd.Receipts)
       .ToListAsync();
        }

        public async Task<Shipping> GetByIdAsync(long Id)
        {
            var res = await dbset.FirstOrDefaultAsync(io => io.Id == Id);
            if (res is not null)
            {
                return res;
            }
            throw new ArgumentException("No relate entity found!");
        }

        public async Task<Shipping> GetByIdWithDetailsAsync(long Id)
        {
            var res = await dbset
                .Include(r => r.Order)
               .ThenInclude(rd => rd.payments)
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

        public void Update(Shipping custom)
        {
            if (dbset.Any(io => io.Id == custom.Id))
            {
                dbset.Update(custom);
                context.SaveChanges();
            }
        }
    }
}
