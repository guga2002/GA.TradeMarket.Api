﻿using GA.TradeMarket.Domain.Data;
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
    public class ReceiptRepository:BaseRepository<Receipt>,IReceiptRepository
    {
        public ReceiptRepository(TradeMarketDbContext context):base(context)
        {
        }

        public async Task AddAsync(Receipt customer)
        {
            if (! await dbset.AnyAsync(io => io.CustomerId == customer.CustomerId && io.OperationDate == customer.OperationDate))
            {
                await dbset.AddAsync(customer);
                await context.SaveChangesAsync();
            }
        }

        public async Task DeleteByIdAsync(int Id)
        {
            var res = await dbset.FirstOrDefaultAsync(io => io.Id == Id);
            dbset.Remove(res ?? throw new ArgumentException("No entity found!"));
            await context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Receipt>> GetAllAsync()
        {
            return await dbset.ToListAsync();
        }

        public async Task<IEnumerable<Receipt>> GetAllWithDetailsAsync()
        {
            return await dbset
       .Include(r => r.Customer)
           .ThenInclude(c => c.Person)
       .Include(r => r.ReceiptDetails)
           .ThenInclude(rd => rd.Product)
           .ThenInclude(io => io.Category)
       .ToListAsync();
        }

        public async Task<Receipt> GetByIdAsync(int Id)
        {
            var res = await dbset.FirstOrDefaultAsync(io => io.Id == Id);
            if (res is not null)
            {
                return res;
            }
            throw new ArgumentException("No relate entity found!");
        }

        public async Task<Receipt> GetByIdWithDetailsAsync(int Id)
        {
            var res = await dbset
               .Include(r => r.Customer)
                .ThenInclude(c => c.Person)
                .Include(r => r.ReceiptDetails)
               .ThenInclude(rd => rd.Product)
               .ThenInclude(io => io.Category)
              .Where(io => io.Id == Id).FirstOrDefaultAsync();
            if (res is not null)
            {
                return res;
            }
            else
            {
                return new Receipt();
            }
        }

        public void Update(Receipt custom)
        {
            if (dbset.Any(io => io.Id == custom.Id))
            {
                dbset.Update(custom);
                context.SaveChanges();
            }
        }
    }
}
