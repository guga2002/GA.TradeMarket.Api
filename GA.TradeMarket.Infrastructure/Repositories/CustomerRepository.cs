using GA.TradeMarket.Domain.Data;
using GA.TradeMarket.Domain.Entitites;
using GA.TradeMarket.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            return await dbset.Include(i => i.Person)
                    .Include(io => io.Receipts)
                      .ThenInclude(io => io.ReceiptDetails)
                      .Include(io => io.Person)
                    .Where(io => io.Receipts != null)
                    .ToListAsync();

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
            var res = await dbset.Include(io => io.Receipts).
                ThenInclude(io => io.ReceiptDetails)
                .Include(io => io.Person).
                FirstOrDefaultAsync(io => io.Id == Id);
            if (res is not null)
            {
                return res;
            }
            throw new ArgumentException("No related entity fond");
        }

        public void Update(Customer custom)
        {
            var user = dbset.Where(io => io.PersonId == custom.PersonId)
                .Include(io => io.Person)
                .FirstOrDefault();
            if (user != null && custom.Person != null)
            {
                user.Person = new Person();

                user.Person.Name = custom.Person.Name;
                user.Person.Surname = custom.Person.Surname;
                user.Person.BirthDate = custom.Person.BirthDate;
                user.DiscountValue = custom.DiscountValue;
                user.OperationDate = custom.OperationDate;
                dbset.Update(user);
                context.SaveChanges();
            }
        }
    }

}
