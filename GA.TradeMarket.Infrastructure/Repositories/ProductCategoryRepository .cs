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
    public class ProductCategoryRepository :BaseRepository<ProductCategory> ,IProductCategoryRepository
    {
        public ProductCategoryRepository(TradeMarketDbContext context):base(context)
        {
        }

        public async Task AddAsync(ProductCategory customer)
        {
            if (customer.CategoryName != null)
            {
                if (!await dbset.AnyAsync(io => io.CategoryName == customer.CategoryName))
                {
                    await dbset.AddAsync(customer);
                    await context.SaveChangesAsync();
                }
            }
        }

        public async Task DeleteByIdAsync(int Id)
        {
            var res = await dbset.FirstOrDefaultAsync(io => io.Id == Id);
            if (res is not null)
            {
                dbset.Remove(res);
                await context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<ProductCategory>> GetAllAsync()
        {

            return await dbset.ToListAsync();
        }

        public async Task<IEnumerable<ProductCategory>> GetAllWithDetailsAsync()
        {
            return await dbset.Include(io => io.Products).ToListAsync();
        }

        public async Task<ProductCategory> GetByIdAsync(int Id)
        {
            var res = await dbset.FirstOrDefaultAsync(io => io.Id == Id);
            if (res is not  null)
            {
                return res;
            }
            throw new ArgumentException("No entity DOund on this ID");
        }

        public async Task<ProductCategory> GetByIdWithDetailsAsync(int Id)
        {
            var res = await dbset.Include(io => io.Products).FirstOrDefaultAsync(io => io.Id == Id);
            if (res != null)
            {
                return res;
            }
            throw new ArgumentException($"No Entity found on this id {Id}");
        }

        public void Update(ProductCategory custom)
        {
            if (dbset.Any(io => io.Id == custom.Id))
            {
                dbset.Update(custom);
                context.SaveChanges();
            }
        }

    }
}
