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

    public class ReceiptDetailRepository : BaseRepository<ReceiptDetail>, IReceiptDetailRepository
    {

        public ReceiptDetailRepository(TradeMarketDbContext context) : base(context)
        {
        }

        public async Task AddAsync(ReceiptDetail customer)
        {
            await dbset.AddAsync(customer);
            await context.SaveChangesAsync();
        }

        public async Task Delete(ReceiptDetail receiptDetail)
        {
            var existingReceiptDetail = await dbset.FindAsync(receiptDetail.ProductId, receiptDetail.ReceiptId);

            if (existingReceiptDetail is not null)
            {
                dbset.Remove(existingReceiptDetail);
                await context.SaveChangesAsync();
            }
            else
            {
                await Console.Out.WriteLineAsync("No  related entity found");
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

        public async Task<IEnumerable<ReceiptDetail>> GetAllAsync()
        {
            return await dbset.ToListAsync();
        }

        public async Task<IEnumerable<ReceiptDetail>> GetAllWithDetailsAsync()
        {
            return await dbset.Include(io => io.Product)
                .ThenInclude(io => io.Category)
                .Include(io => io.Receipt)
                .ThenInclude(io => io.Customer)
                .ToListAsync();
        }

        public async Task<ReceiptDetail> GetByIdAsync(long Id)
        {
            var res = await dbset.FirstOrDefaultAsync(io => io.Id == Id);
            if (res is not null)
            {
                return res;
            }
            throw new ArgumentException("No entity found on this Id  ");
        }

        public async Task<ReceiptDetail> GetByIdWithDetailsAsync(long Id)
        {
            var res = await dbset.Include(io => io.Receipt)
                .Include(io => io.Product)
                .FirstOrDefaultAsync(io => io.Id == Id);
            if (res is not null)
            {
                return res;
            }
            throw new ArgumentException("No entity found");
        }

        public void Update(ReceiptDetail custom)
        {
            if (dbset.Any(io => io.Id == custom.Id))
            {
                dbset.Update(custom);
                context.SaveChanges();
            }
        }

    }
}