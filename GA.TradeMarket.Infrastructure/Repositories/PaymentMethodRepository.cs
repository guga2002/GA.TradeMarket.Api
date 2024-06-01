using GA.TradeMarket.Domain.Data;
using GA.TradeMarket.Domain.Entitites;
using GA.TradeMarket.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace GA.TradeMarket.Infrastructure.Repositories
{
    public class PaymentMethodRepository : BaseRepository<PaymentMethod>, IPaymentMethodRepository
    {
        public PaymentMethodRepository(TradeMarketDbContext context) : base(context)
        {
        }
        public async Task AddAsync(PaymentMethod method)
        {
            if (method is not null)
            {
                if (!await dbset.AnyAsync(io => io.CardNumber == method.CardNumber&&io.CustomerId==method.CustomerId))
                {
                    await dbset.AddAsync(method);
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

        public async Task<IEnumerable<PaymentMethod>> GetAllAsync()
        {
            return await dbset.ToListAsync();
        }

        public async Task<IEnumerable<PaymentMethod>> GetAllWithDetailsAsync()
        {
            return await dbset.Include(io => io.Payments)
                .ThenInclude(io => io.Order)
                .ToListAsync();
        }

        public async Task<PaymentMethod> GetByIdAsync(long Id)
        {
            var res = await dbset.
                FirstOrDefaultAsync(io => io.Id == Id);
            if (res is not null)
            {
                return res;
            }
            throw new ArgumentException("no relate  entity found");
        }

        public async Task<PaymentMethod> GetByIdWithDetailsAsync(long Id)
        {

            var res = await dbset.Include(io => io.Payments)
                .ThenInclude(io => io.Order)
                .FirstOrDefaultAsync(io => io.Id == Id);
            if (res != null)
            {
                return res;
            }
            throw new ArgumentException(" No entity Found");
        }

        public void Update(PaymentMethod method)
        {
            var db = dbset
        .Include(io => io.Payments)
        .ThenInclude(io => io.Order)
        .FirstOrDefault(io => io.CustomerId == method.CustomerId);

            if (db != null)
            {
               db.CardNumber = method.CardNumber;
                db.CardHolderName = method.CardHolderName;
                db.CVV=method.CVV;
                db.ExpiryDate = method.ExpiryDate;
                context.SaveChanges();
            }
        }
    }
}
