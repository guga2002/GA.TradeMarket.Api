using GA.TradeMarket.Domain.Entitites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GA.TradeMarket.Domain.Configurations
{
    public class NotificationConfig : IEntityTypeConfiguration<Notification>
    {
        public void Configure(EntityTypeBuilder<Notification> builder)
        {
            Random rnd = new Random();
            Bogus.Faker fk = new Bogus.Faker();
            builder.HasData(
                new Notification() { NotificationDate = DateTime.Now.AddHours(-rnd.Next(10, 1000)), Message = fk.Lorem.Text(), UserId = 1, Id = 1 },
                new Notification() { NotificationDate = DateTime.Now.AddHours(-rnd.Next(10, 1000)), Message = fk.Lorem.Text(), UserId = 2, Id = 2 },
                new Notification() { NotificationDate = DateTime.Now.AddHours(-rnd.Next(10, 1000)), Message = fk.Lorem.Text(), UserId = 3, Id = 3 },
                new Notification() { NotificationDate = DateTime.Now.AddHours(-rnd.Next(10, 1000)), Message = fk.Lorem.Text(), UserId = 4, Id = 4 },
                new Notification() { NotificationDate = DateTime.Now.AddHours(-rnd.Next(10, 1000)), Message = fk.Lorem.Text(), UserId = 1, Id = 5 },
                new Notification() { NotificationDate = DateTime.Now.AddHours(-rnd.Next(10, 1000)), Message = fk.Lorem.Text(), UserId = 2, Id = 6 },
                new Notification() { NotificationDate = DateTime.Now.AddHours(-rnd.Next(10, 1000)), Message = fk.Lorem.Text(), UserId = 3, Id = 7 },
                new Notification() { NotificationDate = DateTime.Now.AddHours(-rnd.Next(10, 1000)), Message = fk.Lorem.Text(), UserId = 4, Id = 8 },
                new Notification() { NotificationDate = DateTime.Now.AddHours(-rnd.Next(10, 1000)), Message = fk.Lorem.Text(), UserId = 5, Id = 9 },
                new Notification() { NotificationDate = DateTime.Now.AddHours(-rnd.Next(10, 1000)), Message = fk.Lorem.Text(), UserId = 6, Id = 10 },
                new Notification() { NotificationDate = DateTime.Now.AddHours(-rnd.Next(10, 1000)), Message = fk.Lorem.Text(), UserId = 7, Id = 11},
                new Notification() { NotificationDate = DateTime.Now.AddHours(-rnd.Next(10, 1000)), Message = fk.Lorem.Text(), UserId = 8, Id = 12},
                new Notification() { NotificationDate = DateTime.Now.AddHours(-rnd.Next(10, 1000)), Message = fk.Lorem.Text(), UserId = 4, Id = 13},
                new Notification() { NotificationDate = DateTime.Now.AddHours(-rnd.Next(10, 1000)), Message = fk.Lorem.Text(), UserId = 6, Id = 14},
                new Notification() { NotificationDate = DateTime.Now.AddHours(-rnd.Next(10, 1000)), Message = fk.Lorem.Text(), UserId = 7, Id = 15},
                new Notification() { NotificationDate = DateTime.Now.AddHours(-rnd.Next(10, 1000)), Message = fk.Lorem.Text(), UserId = 6, Id = 16},
                new Notification() { NotificationDate = DateTime.Now.AddHours(-rnd.Next(10, 1000)), Message = fk.Lorem.Text(), UserId = 4, Id = 17},
                new Notification() { NotificationDate = DateTime.Now.AddHours(-rnd.Next(10, 1000)), Message = fk.Lorem.Text(), UserId = 8, Id = 18}
                );
        }
    }
}
