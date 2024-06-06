using GA.TradeMarket.Domain.Data;
using GA.TradeMarket.Domain.Entitites;
using GA.TradeMarket.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace GA.TradeMarket.Infrastructure.Repositories
{
    public class ReturnRequestRepository : BaseRepository<ReturnRequest>, IReturnRequestRepository
    {
        public ReturnRequestRepository(TradeMarketDbContext context) : base(context)
        {
        }

        public async Task AddAsync(ReturnRequest customer)
        {
            if (!await dbset.AnyAsync(io => io.OrderId == customer.OrderId))
            {
                await dbset.AddAsync(customer);
                await context.SaveChangesAsync();
            }
            else throw new ArgumentException("You already have made  request , check  the status at first");
        }

        public async Task DeleteByIdAsync(long Id)
        {
            var res = await dbset.FirstOrDefaultAsync(io => io.Id == Id);
            dbset.Remove(res ?? throw new ArgumentException("No entity found!"));
            await context.SaveChangesAsync();
        }

        public async Task<IEnumerable<ReturnRequest>> GetAllAsync()
        {
            return await dbset.ToListAsync();
        }

        public async Task<IEnumerable<ReturnRequest>> GetAllWithDetailsAsync()
        {
            return await dbset
       .Include(r => r.Order)
       .ThenInclude(io => io.Receipts)
       .ToListAsync();
        }

        public async Task<ReturnRequest> GetByIdAsync(long Id)
        {
            var res = await dbset.FindAsync(Id);
            if (res is not null)
            {
                return res;
            }
            throw new ArgumentException("No relate entity found!");
        }

        public async Task<ReturnRequest> GetByIdWithDetailsAsync(long Id)
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

        public void Update(ReturnRequest custom)
        {
            if (dbset.Any(io => io.Id == custom.Id))
            {
                var res = dbset.FirstOrDefault(io => io.Id == custom.Id);
                if (res is not null)
                {
                    res.Status = custom.Status;
                    res.RequestDate = custom.RequestDate;
                    res.Reason = custom.Reason;
                    res.OrderId = custom.OrderId;
                    context.SaveChanges();
                }
            }
            else
            {
                throw new ArgumentException(" no entity found on  this ID");
            }
        }
    }
}
