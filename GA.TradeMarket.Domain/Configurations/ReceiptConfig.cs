using GA.TradeMarket.Domain.Entitites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GA.TradeMarket.Domain.Configurations
{
    public class ReceiptConfig : IEntityTypeConfiguration<Receipt>
    {
        public void Configure(EntityTypeBuilder<Receipt> builder)
        {
            builder.HasData(
                    new Receipt() { IsCheckedOut = false, OrderId = 1, Id = 1 },
                    new Receipt() { IsCheckedOut = true, OrderId = 2, Id = 2 },
                    new Receipt() { IsCheckedOut = false, OrderId = 3, Id = 3 },
                    new Receipt() { IsCheckedOut = true, OrderId = 1, Id = 4 },
                    new Receipt() { IsCheckedOut = false, OrderId = 4, Id = 5 },
                    new Receipt() { IsCheckedOut = false, OrderId = 3, Id = 6 },
                    new Receipt() { IsCheckedOut = true, OrderId = 2, Id = 7 },
                    new Receipt() { IsCheckedOut = false, OrderId = 3, Id = 8 },
                    new Receipt() { IsCheckedOut = true, OrderId = 2, Id = 9 },
                    new Receipt() { IsCheckedOut = false, OrderId = 1, Id = 10 },
                     new Receipt() { IsCheckedOut = false, OrderId = 1, Id = 11 },
                    new Receipt() { IsCheckedOut = true, OrderId = 14, Id = 12 },
                    new Receipt() { IsCheckedOut = false, OrderId = 13, Id = 13 },
                    new Receipt() { IsCheckedOut = true, OrderId = 17, Id = 14 },
                    new Receipt() { IsCheckedOut = false, OrderId = 18, Id = 15 },
                    new Receipt() { IsCheckedOut = false, OrderId = 19, Id = 16 },
                    new Receipt() { IsCheckedOut = true, OrderId = 20, Id = 17 },
                    new Receipt() { IsCheckedOut = false, OrderId = 21, Id = 18 },
                    new Receipt() { IsCheckedOut = true, OrderId = 9, Id = 19 },
                    new Receipt() { IsCheckedOut = false, OrderId = 20, Id = 20 }
                    );
        }
    }
}
