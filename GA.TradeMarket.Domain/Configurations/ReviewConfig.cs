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
    public class ReviewConfig : IEntityTypeConfiguration<Review>
    {
        public void Configure(EntityTypeBuilder<Review> builder)
        {
            Bogus.Faker fk = new Bogus.Faker();
            builder.HasData(
                new Review() { CustomerId = 1, ReviewDate = DateTime.Now.AddDays(-15), ProductId = 1, Rating = 3, ReviewText = fk.Lorem.Text(), Id = 1 },
                new Review() { CustomerId = 2, ReviewDate = DateTime.Now.AddDays(-54), ProductId = 2, Rating = 5, ReviewText = fk.Lorem.Text(), Id = 2 },
                new Review() { CustomerId = 3, ReviewDate = DateTime.Now.AddDays(-23), ProductId = 3, Rating = 4, ReviewText = fk.Lorem.Text(), Id = 3 },
                new Review() { CustomerId = 2, ReviewDate = DateTime.Now.AddDays(-2), ProductId = 4, Rating = 3, ReviewText = fk.Lorem.Text(), Id = 4 },
                new Review() { CustomerId = 2, ReviewDate = DateTime.Now.AddDays(-34), ProductId = 5, Rating = 2, ReviewText = fk.Lorem.Text(), Id = 5 },
                new Review() { CustomerId = 1, ReviewDate = DateTime.Now.AddDays(-35), ProductId = 6, Rating = 4, ReviewText = fk.Lorem.Text(), Id = 6 },
                  new Review() { CustomerId = 5, ReviewDate = DateTime.Now.AddDays(-15), ProductId = 11, Rating = 3, ReviewText = fk.Lorem.Text(), Id = 7 },
                new Review() { CustomerId = 6, ReviewDate = DateTime.Now.AddDays(-54), ProductId = 12, Rating = 5, ReviewText = fk.Lorem.Text(), Id =8 },
                new Review() { CustomerId = 7, ReviewDate = DateTime.Now.AddDays(-23), ProductId = 7, Rating = 4, ReviewText = fk.Lorem.Text(), Id = 9 },
                new Review() { CustomerId = 8, ReviewDate = DateTime.Now.AddDays(-2), ProductId = 13, Rating = 3, ReviewText = fk.Lorem.Text(), Id = 10 }
                    );
        }
    }
}
