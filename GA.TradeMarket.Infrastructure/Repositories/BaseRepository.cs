using GA.TradeMarket.Domain.Data;
using GA.TradeMarket.Domain.Entitites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA.TradeMarket.Infrastructure.Repositories
{
    public abstract class BaseRepository<T>where T:class
    {
        protected readonly  TradeMarketDbContext context;

        protected DbSet<T> dbset;

        protected BaseRepository(TradeMarketDbContext context)
        {
            this.context = context;
            dbset = context.Set<T>();
        }

    }
}
