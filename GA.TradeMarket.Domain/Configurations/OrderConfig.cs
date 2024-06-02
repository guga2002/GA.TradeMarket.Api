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
                new Order() { CustomerId = 2, Status = "Done", Id = 2, OrderDate = DateTime.Now.AddDays(-rnd.Next(1, 30)) },
                new Order() { CustomerId = 3, Status = "Done", Id = 3, OrderDate = DateTime.Now.AddDays(-rnd.Next(1, 30)) },
                new Order() { CustomerId = 2, Status = "Done", Id = 4, OrderDate = DateTime.Now.AddDays(-rnd.Next(1, 30)) },
                new Order() { CustomerId = 3, Status = "Done", Id = 5, OrderDate = DateTime.Now.AddDays(-rnd.Next(1, 30)) },
                new Order() { CustomerId = 4, Status = "Done", Id = 6, OrderDate = DateTime.Now.AddDays(-rnd.Next(1, 30)) },
                new Order() { CustomerId = 2, Status = "Done", Id = 7, OrderDate = DateTime.Now.AddDays(-rnd.Next(1, 30)) },
                new Order() { CustomerId = 1, Status = "Done", Id = 8, OrderDate = DateTime.Now.AddDays(-rnd.Next(1, 30)) },
                new Order() { CustomerId = 4, Status = "Done", Id = 9, OrderDate = DateTime.Now.AddDays(-rnd.Next(1, 30)) },
                new Order() { CustomerId = 2, Status = "Done", Id = 10, OrderDate = DateTime.Now.AddDays(-rnd.Next(1, 30)) },
                new Order() { CustomerId = 1, Status = "Done", Id = 11, OrderDate = DateTime.Now.AddDays(-rnd.Next(1, 30)) }
                );
        }
    }
}
