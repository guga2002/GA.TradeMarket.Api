using GA.TradeMarket.Domain.Entitites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GA.TradeMarket.Domain.Configurations
{
    public class ProductCategoryConfig : IEntityTypeConfiguration<ProductCategory>
    {
        public void Configure(EntityTypeBuilder<ProductCategory> builder)
        {
            Bogus.Faker fk = new Bogus.Faker();
            builder.HasData(
                new ProductCategory() { CategoryName = fk.Commerce.Categories(1)[0], Id = 1 },
                 new ProductCategory() { CategoryName = fk.Commerce.Categories(2)[1], Id = 2 },
                  new ProductCategory() { CategoryName = fk.Commerce.Categories(5)[3], Id = 3 },
                   new ProductCategory() { CategoryName = fk.Commerce.Categories(5)[2], Id = 4 },
                    new ProductCategory() { CategoryName = fk.Commerce.Categories(6)[4], Id = 5 },
                    new ProductCategory() { CategoryName = fk.Commerce.Categories(7)[3], Id = 6 },
                    new ProductCategory() { CategoryName = fk.Commerce.Categories(8)[2], Id = 7 },
                    new ProductCategory() { CategoryName = fk.Commerce.Categories(3)[1], Id = 8 },
                    new ProductCategory() { CategoryName = fk.Commerce.Categories(4)[1], Id = 9 },
                  new ProductCategory() { CategoryName = fk.Commerce.Categories(1)[0], Id = 10 },
                   new ProductCategory() { CategoryName = fk.Commerce.Categories(1)[0], Id = 11 },
                 new ProductCategory() { CategoryName = fk.Commerce.Categories(2)[1], Id = 12 },
                  new ProductCategory() { CategoryName = fk.Commerce.Categories(5)[3], Id = 13 },
                   new ProductCategory() { CategoryName = fk.Commerce.Categories(5)[2], Id = 14 },
                    new ProductCategory() { CategoryName = fk.Commerce.Categories(6)[4], Id = 15 },
                    new ProductCategory() { CategoryName = fk.Commerce.Categories(7)[3], Id = 16 },
                    new ProductCategory() { CategoryName = fk.Commerce.Categories(8)[2], Id = 17 },
                    new ProductCategory() { CategoryName = fk.Commerce.Categories(3)[1], Id = 18 },
                    new ProductCategory() { CategoryName = fk.Commerce.Categories(4)[1], Id = 19 },
                  new ProductCategory() { CategoryName = fk.Commerce.Categories(1)[0], Id = 20 }
                );
        }
    }
}
