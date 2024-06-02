using GA.TradeMarket.Domain.Entitites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GA.TradeMarket.Domain.Configurations
{
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        Bogus.Faker fk = new Bogus.Faker();
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product() { Id = 1, ProductCategoryId = 1, Price = fk.Commerce.Random.Decimal(), ProductName = fk.Commerce.ProductName() },
                 new Product() { Id = 2, ProductCategoryId = 2, Price = fk.Commerce.Random.Decimal(), ProductName = fk.Commerce.ProductName() },
                  new Product() { Id = 3, ProductCategoryId = 3, Price = fk.Commerce.Random.Decimal(), ProductName = fk.Commerce.ProductName() },
                  new Product() { Id = 4, ProductCategoryId = 4, Price = fk.Commerce.Random.Decimal(), ProductName = fk.Commerce.ProductName() },
                  new Product() { Id = 5, ProductCategoryId = 5, Price = fk.Commerce.Random.Decimal(), ProductName = fk.Commerce.ProductName() },
                 new Product() { Id = 6, ProductCategoryId = 6, Price = fk.Commerce.Random.Decimal(), ProductName = fk.Commerce.ProductName() },
                  new Product() { Id = 7, ProductCategoryId = 7, Price = fk.Commerce.Random.Decimal(), ProductName = fk.Commerce.ProductName() },
                   new Product() { Id = 8, ProductCategoryId = 8, Price = fk.Commerce.Random.Decimal(), ProductName = fk.Commerce.ProductName() },
                    new Product() { Id = 9, ProductCategoryId = 9, Price = fk.Commerce.Random.Decimal(), ProductName = fk.Commerce.ProductName() },
                    new Product() { Id = 10, ProductCategoryId = 1, Price = fk.Commerce.Random.Decimal(), ProductName = fk.Commerce.ProductName() },
                    new Product() { Id = 11, ProductCategoryId = 3, Price = fk.Commerce.Random.Decimal(), ProductName = fk.Commerce.ProductName() },
                    new Product() { Id = 12, ProductCategoryId = 4, Price = fk.Commerce.Random.Decimal(), ProductName = fk.Commerce.ProductName() },
                    new Product() { Id = 13, ProductCategoryId = 3, Price = fk.Commerce.Random.Decimal(), ProductName = fk.Commerce.ProductName() },
                    new Product() { Id = 14, ProductCategoryId = 6, Price = fk.Commerce.Random.Decimal(), ProductName = fk.Commerce.ProductName() },
                      new Product() { Id = 15, ProductCategoryId = 1, Price = fk.Commerce.Random.Decimal(), ProductName = fk.Commerce.ProductName() },
                 new Product() { Id = 16, ProductCategoryId = 2, Price = fk.Commerce.Random.Decimal(), ProductName = fk.Commerce.ProductName() },
                  new Product() { Id = 17, ProductCategoryId = 3, Price = fk.Commerce.Random.Decimal(), ProductName = fk.Commerce.ProductName() },
                  new Product() { Id = 18, ProductCategoryId = 4, Price = fk.Commerce.Random.Decimal(), ProductName = fk.Commerce.ProductName() },
                  new Product() { Id = 19, ProductCategoryId = 5, Price = fk.Commerce.Random.Decimal(), ProductName = fk.Commerce.ProductName() },
                 new Product() { Id = 20, ProductCategoryId = 6, Price = fk.Commerce.Random.Decimal(), ProductName = fk.Commerce.ProductName() },
                  new Product() { Id = 21, ProductCategoryId = 7, Price = fk.Commerce.Random.Decimal(), ProductName = fk.Commerce.ProductName() },
                   new Product() { Id = 22, ProductCategoryId = 8, Price = fk.Commerce.Random.Decimal(), ProductName = fk.Commerce.ProductName() },
                    new Product() { Id = 23, ProductCategoryId = 9, Price = fk.Commerce.Random.Decimal(), ProductName = fk.Commerce.ProductName() },
                    new Product() { Id = 24, ProductCategoryId = 1, Price = fk.Commerce.Random.Decimal(), ProductName = fk.Commerce.ProductName() },
                    new Product() { Id = 25, ProductCategoryId = 3, Price = fk.Commerce.Random.Decimal(), ProductName = fk.Commerce.ProductName() },
                    new Product() { Id = 26, ProductCategoryId = 4, Price = fk.Commerce.Random.Decimal(), ProductName = fk.Commerce.ProductName() },
                    new Product() { Id = 27, ProductCategoryId = 3, Price = fk.Commerce.Random.Decimal(), ProductName = fk.Commerce.ProductName() },
                    new Product() { Id = 28, ProductCategoryId = 6, Price = fk.Commerce.Random.Decimal(), ProductName = fk.Commerce.ProductName() }
                    );
        }
    }
}
