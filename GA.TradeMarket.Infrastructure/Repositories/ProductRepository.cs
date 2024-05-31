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
    public class ProductRepository:BaseRepository<Product>,IProductRepository
    {

        public ProductRepository(TradeMarketDbContext context):base(context)
        {
        }

        public async Task AddAsync(Product customer)
        {
            if (customer.ProductName is not null)
            {
                if (!await dbset.AnyAsync(io => io.ProductName == customer.ProductName))
                {
                    await dbset.AddAsync(new Product()
                    {
                        Price = customer.Price,
                        ProductCategoryId = customer.ProductCategoryId,
                        ProductName = customer.ProductName
                    });
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

        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            return await dbset.ToListAsync();
        }

        public async Task<IEnumerable<Product>> GetAllWithDetailsAsync()
        {
            return await dbset.Include(io => io.ReceiptDetails)
                .Include(io => io.Category)
                .ToListAsync();
        }

        public async Task<Product> GetByIdAsync(int Id)
        {
            var res = await dbset.
                FirstOrDefaultAsync(io => io.Id == Id);
            if (res is not null)
            {
                return res;
            }
            throw new ArgumentException("no relate  entity found");
        }

        public async Task<Product> GetByIdWithDetailsAsync(int Id)
        {

            var res = await dbset.Include(io => io.ReceiptDetails)
                .Include(io => io.Category)
                .FirstOrDefaultAsync(io => io.Id == Id);
            if (res != null)
            {
                return res;
            }
            return new Product() { ProductName="undefined"};
        }

        public void Update(Product custom)
        {
            var db = dbset
        .Include(io => io.Category)
        .Include(io => io.ReceiptDetails)
        .FirstOrDefault(io => io.Id == custom.Id);

            if (db != null && db.Category != null && custom.Category != null)
            {
                db.Price = custom.Price;
                db.ProductName = custom.ProductName;
                db.Category.CategoryName = custom.Category.CategoryName;
                db.ProductCategoryId = custom.ProductCategoryId;

                context.SaveChanges();
            }
        }
    }
}
