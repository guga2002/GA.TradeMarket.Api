using Bogus;
using GA.TradeMarket.Domain.Entitites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA.TradeMarket.Domain.Configurations
{
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        Faker fk = new Faker();
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
                    new Product() { Id = 14, ProductCategoryId = 6, Price = fk.Commerce.Random.Decimal(), ProductName = fk.Commerce.ProductName() }
                    );
        }
    }
}
