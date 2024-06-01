using GA.TradeMarket.Domain.Data;
using GA.TradeMarket.Domain.Entitites;
using GA.TradeMarket.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace GA.TradeMarket.Infrastructure.Repositories
{
    public class OrderRepository : BaseRepository<Order>, IOrderRepository
    {
        public OrderRepository(TradeMarketDbContext context) : base(context)
        {
        }
        public async Task AddAsync(Order customer)
        {
            if (!await dbset.AnyAsync(io => io.CustomerId == customer.CustomerId&&io.Status==customer.Status))
            {
                await dbset.AddAsync(customer);
                await context.SaveChangesAsync();
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

        public async Task<IEnumerable<Order>> GetAllAsync()
        {
            return await dbset.ToListAsync();
        }

        public async Task<IEnumerable<Order>> GetAllWithDetailsAsync()
        {
            return await dbset.Include(i => i.Shipping)
                    .Include(io => io.ReturnRequest)
                      .Include(io => io.payments)
                      .Include(io=>io.Customer)
                    .ToListAsync();

        }

        public async Task<Order> GetByIdAsync(long Id)
        {
            var res = await dbset.FirstOrDefaultAsync(io => io.Id == Id);
            if (res != null)
            {
                return res;
            }
            throw new ArgumentException("No  entity found on this Id");
        }

        public async Task<Order> GetByIdWithDetailsAsync(long Id)
        {
            var res = await dbset.Include(io => io.ReturnRequest)
                      .Include(io => io.payments)
                      .Include(io => io.Customer).FirstOrDefaultAsync(io => io.Id == Id);
            if (res is not null)
            {
                return res;
            }
            throw new ArgumentException("No related entity fond");
        }

        public void Update(Order order)
        {
            var user = dbset.Where(io => io.CustomerId == order.CustomerId)
                .Include(io => io.payments)
                .FirstOrDefault();
            if (user != null)
            {
                user.OrderDate = order.OrderDate;
                user.CustomerId = order.CustomerId;
                user.Status = order.Status;
                dbset.Update(user);
                context.SaveChanges();
            }
        }
    }
}
