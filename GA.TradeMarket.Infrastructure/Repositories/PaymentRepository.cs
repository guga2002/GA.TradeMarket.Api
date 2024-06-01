using GA.TradeMarket.Domain.Data;
using GA.TradeMarket.Domain.Entitites;
using GA.TradeMarket.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace GA.TradeMarket.Infrastructure.Repositories
{
    public class PaymentRepository : BaseRepository<Payment>, IPaymentRepository
    {
        public PaymentRepository(TradeMarketDbContext context) : base(context)
        {
        }
        public async Task AddAsync(Payment method)
        {
            if (method is not null)
            {
                if (!await dbset.AnyAsync(io => io.paymentMethodId == method.paymentMethodId && io.OrderId == method.OrderId))
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

        public async Task<IEnumerable<Payment>> GetAllAsync()
        {
            return await dbset.ToListAsync();
        }

        public async Task<IEnumerable<Payment>> GetAllWithDetailsAsync()
        {
            return await dbset.Include(io => io.Order)
                .ThenInclude(io => io.Receipts)
                .ToListAsync();
        }

        public async Task<Payment> GetByIdAsync(long Id)
        {
            var res = await dbset.
                FirstOrDefaultAsync(io => io.Id == Id);
            if (res is not null)
            {
                return res;
            }
            throw new ArgumentException("no relate  entity found");
        }

        public async Task<Payment> GetByIdWithDetailsAsync(long Id)
        {

            var res = await dbset.Include(io => io.Order)
                .ThenInclude(io => io.Receipts)
                .FirstOrDefaultAsync(io => io.Id == Id);
            if (res != null)
            {
                return res;
            }
            throw new ArgumentException(" No entity Found");
        }

        public void Update(Payment method)
        {
            var db = dbset
        .Include(io => io.method)
        .ThenInclude(io => io.Payments)
        .FirstOrDefault(io => io.paymentMethodId == method.paymentMethodId);

            if (db != null)
            {
                db.Amount = method.Amount;
                db.OrderId = method.OrderId;
                db.PaymentDate = method.PaymentDate;
                context.SaveChanges();
            }
        }
    }
}
