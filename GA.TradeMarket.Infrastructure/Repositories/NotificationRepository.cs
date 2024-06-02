using GA.TradeMarket.Domain.Data;
using GA.TradeMarket.Domain.Entitites;
using GA.TradeMarket.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace GA.TradeMarket.Infrastructure.Repositories
{
    public class NotificationRepository : BaseRepository<Notification>, INotificationRepository
    {
        public NotificationRepository(TradeMarketDbContext context) : base(context)
        {
        }
        public async Task AddAsync(Notification notifictation)
        {
            if (notifictation is not null)
            {
                if (!await dbset.AnyAsync(io => io.UserId == notifictation.UserId&&io.Message== notifictation.Message))
                {
                    await dbset.AddAsync(notifictation);
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

        public async Task<IEnumerable<Notification>> GetAllAsync()
        {

            return await dbset.ToListAsync();
        }

        public async Task<IEnumerable<Notification>> GetAllWithDetailsAsync()
        {
            return await dbset.Include(io=>io.User).ThenInclude(io=>io.Orders).ToListAsync();
        }

        public async Task<Notification> GetByIdAsync(long Id)
        {
            var res = await dbset.FirstOrDefaultAsync(io => io.Id == Id);
            if (res is not null)
            {
                return res;
            }
            throw new ArgumentException("No entity found on this ID");
        }

        public async Task<Notification> GetByIdWithDetailsAsync(long Id)
        {
            var res = await dbset.Include(io=>io.User).FirstOrDefaultAsync(io => io.Id == Id);
            if (res != null)
            {
                return res;
            }
            throw new ArgumentException($"No Entity found on this id {Id}");
        }

        public void Update(Notification coupon)
        {
            if (dbset.Any(io => io.Id == coupon.Id))
            {
                dbset.Update(coupon);
                context.SaveChanges();
            }
        }
    }
}
