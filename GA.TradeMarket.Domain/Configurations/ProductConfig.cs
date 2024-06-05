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
                      new Product() { Id = 15, ProductCategoryId = 11, Price = fk.Commerce.Random.Decimal(), ProductName = fk.Commerce.ProductName() },
                 new Product() { Id = 16, ProductCategoryId = 12, Price = fk.Commerce.Random.Decimal(), ProductName = fk.Commerce.ProductName() },
                  new Product() { Id = 17, ProductCategoryId = 13, Price = fk.Commerce.Random.Decimal(), ProductName = fk.Commerce.ProductName() },
                  new Product() { Id = 18, ProductCategoryId = 14, Price = fk.Commerce.Random.Decimal(), ProductName = fk.Commerce.ProductName() },
                  new Product() { Id = 19, ProductCategoryId = 15, Price = fk.Commerce.Random.Decimal(), ProductName = fk.Commerce.ProductName() },
                 new Product() { Id = 20, ProductCategoryId = 16, Price = fk.Commerce.Random.Decimal(), ProductName = fk.Commerce.ProductName() },
                  new Product() { Id = 21, ProductCategoryId = 17, Price = fk.Commerce.Random.Decimal(), ProductName = fk.Commerce.ProductName() },
                   new Product() { Id = 22, ProductCategoryId = 8, Price = fk.Commerce.Random.Decimal(), ProductName = fk.Commerce.ProductName() },
                    new Product() { Id = 23, ProductCategoryId = 9, Price = fk.Commerce.Random.Decimal(), ProductName = fk.Commerce.ProductName() },
                    new Product() { Id = 24, ProductCategoryId = 14, Price = fk.Commerce.Random.Decimal(), ProductName = fk.Commerce.ProductName() },
                    new Product() { Id = 25, ProductCategoryId = 13, Price = fk.Commerce.Random.Decimal(), ProductName = fk.Commerce.ProductName() },
                    new Product() { Id = 26, ProductCategoryId = 4, Price = fk.Commerce.Random.Decimal(), ProductName = fk.Commerce.ProductName() },
                    new Product() { Id = 27, ProductCategoryId = 3, Price = fk.Commerce.Random.Decimal(), ProductName = fk.Commerce.ProductName() },
                    new Product() { Id = 28, ProductCategoryId = 6, Price = fk.Commerce.Random.Decimal(), ProductName = fk.Commerce.ProductName() },
                      new Product() { Id = 29, ProductCategoryId = 1, Price = fk.Commerce.Random.Decimal(), ProductName = fk.Commerce.ProductName() },
                 new Product() { Id = 30, ProductCategoryId = 2, Price = fk.Commerce.Random.Decimal(), ProductName = fk.Commerce.ProductName() },
                  new Product() { Id = 31, ProductCategoryId = 3, Price = fk.Commerce.Random.Decimal(), ProductName = fk.Commerce.ProductName() },
                  new Product() { Id = 32, ProductCategoryId = 4, Price = fk.Commerce.Random.Decimal(), ProductName = fk.Commerce.ProductName() },
                  new Product() { Id = 33, ProductCategoryId = 5, Price = fk.Commerce.Random.Decimal(), ProductName = fk.Commerce.ProductName() },
                 new Product() { Id = 34, ProductCategoryId = 6, Price = fk.Commerce.Random.Decimal(), ProductName = fk.Commerce.ProductName() },
                  new Product() { Id = 35, ProductCategoryId = 7, Price = fk.Commerce.Random.Decimal(), ProductName = fk.Commerce.ProductName() },
                   new Product() { Id = 36, ProductCategoryId = 8, Price = fk.Commerce.Random.Decimal(), ProductName = fk.Commerce.ProductName() },
                    new Product() { Id = 37, ProductCategoryId = 9, Price = fk.Commerce.Random.Decimal(), ProductName = fk.Commerce.ProductName() },
                    new Product() { Id = 38, ProductCategoryId = 1, Price = fk.Commerce.Random.Decimal(), ProductName = fk.Commerce.ProductName() },
                    new Product() { Id = 39, ProductCategoryId = 11, Price = fk.Commerce.Random.Decimal(), ProductName = fk.Commerce.ProductName() },
                    new Product() { Id = 40, ProductCategoryId = 14, Price = fk.Commerce.Random.Decimal(), ProductName = fk.Commerce.ProductName() },
                    new Product() { Id = 41, ProductCategoryId = 3, Price = fk.Commerce.Random.Decimal(), ProductName = fk.Commerce.ProductName() },
                    new Product() { Id = 42, ProductCategoryId = 6, Price = fk.Commerce.Random.Decimal(), ProductName = fk.Commerce.ProductName() },
                      new Product() { Id = 43, ProductCategoryId = 15, Price = fk.Commerce.Random.Decimal(), ProductName = fk.Commerce.ProductName() },
                 new Product() { Id = 44, ProductCategoryId = 2, Price = fk.Commerce.Random.Decimal(), ProductName = fk.Commerce.ProductName() },
                  new Product() { Id = 45, ProductCategoryId = 18, Price = fk.Commerce.Random.Decimal(), ProductName = fk.Commerce.ProductName() },
                  new Product() { Id = 46, ProductCategoryId = 4, Price = fk.Commerce.Random.Decimal(), ProductName = fk.Commerce.ProductName() },
                  new Product() { Id = 47, ProductCategoryId = 15, Price = fk.Commerce.Random.Decimal(), ProductName = fk.Commerce.ProductName() },
                 new Product() { Id = 48, ProductCategoryId = 19, Price = fk.Commerce.Random.Decimal(), ProductName = fk.Commerce.ProductName() },
                  new Product() { Id = 49, ProductCategoryId = 20, Price = fk.Commerce.Random.Decimal(), ProductName = fk.Commerce.ProductName() },
                   new Product() { Id = 50, ProductCategoryId = 8, Price = fk.Commerce.Random.Decimal(), ProductName = fk.Commerce.ProductName() },
                    new Product() { Id = 51, ProductCategoryId = 14, Price = fk.Commerce.Random.Decimal(), ProductName = fk.Commerce.ProductName() },
                    new Product() { Id = 52, ProductCategoryId = 13, Price = fk.Commerce.Random.Decimal(), ProductName = fk.Commerce.ProductName() },
                    new Product() { Id = 53, ProductCategoryId = 19, Price = fk.Commerce.Random.Decimal(), ProductName = fk.Commerce.ProductName() },
                    new Product() { Id = 54, ProductCategoryId = 16, Price = fk.Commerce.Random.Decimal(), ProductName = fk.Commerce.ProductName() },
                    new Product() { Id = 55, ProductCategoryId = 11, Price = fk.Commerce.Random.Decimal(), ProductName = fk.Commerce.ProductName() },
                    new Product() { Id = 56, ProductCategoryId = 13, Price = fk.Commerce.Random.Decimal(), ProductName = fk.Commerce.ProductName() }
                    );
        }
    }
}
