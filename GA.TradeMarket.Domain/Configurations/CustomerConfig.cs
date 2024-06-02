using Bogus;
using GA.TradeMarket.Domain.Entitites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GA.TradeMarket.Domain.Configurations
{
    public class CustomerConfig : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            Random ran = new Random();
            builder.HasData(
                new Customer() { DiscountValue =ran.Next(100,1000) , OperationDate = DateTime.Now.AddHours(-ran.Next(100, 10000)), PersonId = "1", Id = 1 },
                new Customer() { DiscountValue = ran.Next(100, 1000), OperationDate = DateTime.Now.AddHours(-ran.Next(100, 10000)), PersonId = "2", Id = 2 },
                new Customer() { DiscountValue = ran.Next(100, 1000), OperationDate = DateTime.Now.AddHours(-ran.Next(100, 10000)), PersonId = "3", Id = 3 },
                new Customer() { DiscountValue = ran.Next(100, 1000), OperationDate = DateTime.Now.AddHours(-ran.Next(100, 10000)), PersonId = "4", Id = 4 }
                );
        }
    }
}
