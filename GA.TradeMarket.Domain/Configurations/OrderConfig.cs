using GA.TradeMarket.Domain.Entitites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GA.TradeMarket.Domain.Configurations
{
    public class OrderConfig : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            Random rnd=new Random();
            builder.HasData(
                new Order() { CustomerId = 1, Status = "Done", Id = 1, OrderDate = DateTime.Now.AddDays(-rnd.Next(1, 30)) },
                new Order() { CustomerId = 2, Status = "Decline", Id = 2, OrderDate = DateTime.Now.AddDays(-rnd.Next(1, 30)) },
                new Order() { CustomerId = 3, Status = "Done", Id = 3, OrderDate = DateTime.Now.AddDays(-rnd.Next(1, 30)) },
                new Order() { CustomerId = 2, Status = "processing", Id = 4, OrderDate = DateTime.Now.AddDays(-rnd.Next(1, 30)) },
                new Order() { CustomerId = 3, Status = "Done", Id = 5, OrderDate = DateTime.Now.AddDays(-rnd.Next(1, 30)) },
                new Order() { CustomerId = 4, Status = "Sent", Id = 6, OrderDate = DateTime.Now.AddDays(-rnd.Next(1, 30)) },
                new Order() { CustomerId = 2, Status = "done", Id = 7, OrderDate = DateTime.Now.AddDays(-rnd.Next(1, 30)) },
                new Order() { CustomerId = 1, Status = "Done", Id = 8, OrderDate = DateTime.Now.AddDays(-rnd.Next(1, 30)) },
                new Order() { CustomerId = 4, Status = "Done", Id = 9, OrderDate = DateTime.Now.AddDays(-rnd.Next(1, 30)) },
                new Order() { CustomerId = 2, Status = "done", Id = 10, OrderDate = DateTime.Now.AddDays(-rnd.Next(1, 30)) },
                new Order() { CustomerId = 1, Status = "Done", Id = 11, OrderDate = DateTime.Now.AddDays(-rnd.Next(1, 30)) },
                 new Order() { CustomerId = 5, Status = "Done", Id = 12, OrderDate = DateTime.Now.AddDays(-rnd.Next(1, 30)) },
                new Order() { CustomerId = 6, Status = "Decline", Id = 13, OrderDate = DateTime.Now.AddDays(-rnd.Next(1, 30)) },
                new Order() { CustomerId = 7, Status = "Done", Id = 14, OrderDate = DateTime.Now.AddDays(-rnd.Next(1, 30)) },
                new Order() { CustomerId = 2, Status = "processing", Id = 15, OrderDate = DateTime.Now.AddDays(-rnd.Next(1, 30)) },
                new Order() { CustomerId = 8, Status = "Done", Id = 16, OrderDate = DateTime.Now.AddDays(-rnd.Next(1, 30)) },
                new Order() { CustomerId = 5, Status = "done", Id = 17, OrderDate = DateTime.Now.AddDays(-rnd.Next(1, 30)) },
                new Order() { CustomerId = 2, Status = "done", Id = 18, OrderDate = DateTime.Now.AddDays(-rnd.Next(1, 30)) },
                new Order() { CustomerId = 7, Status = "Sent", Id = 19, OrderDate = DateTime.Now.AddDays(-rnd.Next(1, 30)) },
                new Order() { CustomerId = 6, Status = "Done", Id = 20, OrderDate = DateTime.Now.AddDays(-rnd.Next(1, 30)) },
                new Order() { CustomerId = 7, Status = "Processing", Id = 21, OrderDate = DateTime.Now.AddDays(-rnd.Next(1, 30)) },
                new Order() { CustomerId = 8, Status = "Done", Id = 22, OrderDate = DateTime.Now.AddDays(-rnd.Next(1, 30)) }
                );
        }
    }
}
