using GA.TradeMarket.Domain.Data;
using GA.TradeMarket.Domain.Entitites;
using GA.TradeMarket.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace GA.TradeMarket.Infrastructure.Repositories
{
    public class CustomerRepository :BaseRepository<Customer>, ICustomerRepository
    {

        public CustomerRepository(TradeMarketDbContext context):base(context)
        {
        }

        public async Task AddAsync(Customer customer)
        {
            await dbset.AddAsync(customer);
            await context.SaveChangesAsync();
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

        public async Task<IEnumerable<Customer>> GetAllAsync()
        {
            return await dbset.ToListAsync();
        }

        public async Task<IEnumerable<Customer>> GetAllWithDetailsAsync()
        {
            return await dbset
                       .Include(io => io.Person)
                        .Include(io=>io.Reviews).
                        ThenInclude(io=>io.Product).
                        Include(io=>io.Orders).
                        ThenInclude(io=>io.ReturnRequest).
                        Include(io=>io.Notifications).
                    ToListAsync();
        }

        public async Task<Customer> GetByIdAsync(long Id)
        {
            var res = await dbset.FirstOrDefaultAsync(io => io.Id == Id);
            if (res != null)
            {
                return res;
            }
            throw new ArgumentException("No  entity found on this Id");
        }

        public async Task<Customer> GetByIdWithDetailsAsync(long Id)
        {
            var res = await dbset.Include(io => io.bonuses).Include(io=>io.Person).
                FirstOrDefaultAsync(io => io.Id == Id);
            if (res is not null)
            {
                return res;
            }
            throw new ArgumentException("No related entity fond");
        }

        public void Update(Customer custom)
        {
            var user = dbset.Where(io => io.Id == custom.Id)
                .Include(io => io.Person)
                .FirstOrDefault();
            if (user != null && custom.Person != null)
            {
                user.Person = new Person();
                user.DiscountValue = custom.DiscountValue;
                user.OperationDate = custom.OperationDate;
                dbset.Update(user);
                context.SaveChanges();
            }
        }
    }

}
