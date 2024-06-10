using GA.TradeMarket.Domain.Entitites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GA.TradeMarket.Domain.Configurations
{
    public class WIshListConfiguration : IEntityTypeConfiguration<WIshList>
    {
        public void Configure(EntityTypeBuilder<WIshList> builder)
        {
            builder.HasData(
                new WIshList() { DateOfLastModification = DateTime.Now, CustomerId = 1, productId = 1, Id = 1 },
                 new WIshList() { DateOfLastModification = DateTime.Now, CustomerId = 2, productId = 21, Id = 2 },
                  new WIshList() { DateOfLastModification = DateTime.Now, CustomerId = 3, productId = 3, Id = 3 },
                   new WIshList() { DateOfLastModification = DateTime.Now, CustomerId = 4, productId = 4, Id = 4 },
                 new WIshList() { DateOfLastModification = DateTime.Now, CustomerId = 5, productId = 5, Id = 5 },
                  new WIshList() { DateOfLastModification = DateTime.Now, CustomerId = 6, productId = 6, Id = 6 }
                  );
        }
    }
}
