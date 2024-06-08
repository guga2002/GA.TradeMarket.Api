using GA.TradeMarket.Domain.Data;
using Microsoft.EntityFrameworkCore;

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
