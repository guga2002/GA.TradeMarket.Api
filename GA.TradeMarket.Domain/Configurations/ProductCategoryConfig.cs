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
                  new ProductCategory() { CategoryName = fk.Commerce.Categories(1)[0], Id = 10 }
                );
        }
    }
}
