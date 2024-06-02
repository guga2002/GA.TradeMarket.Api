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
            Faker fk = new Faker();
            builder.HasData(
                new Review() { CustomerId = 1, ReviewDate = DateTime.Now.AddDays(-fk.Random.Int()), ProductId = 1, Rating = 3, ReviewText = fk.Lorem.Text(), Id = 1 },
                new Review() { CustomerId = 2, ReviewDate = DateTime.Now.AddDays(-fk.Random.Int()), ProductId = 2, Rating = 5, ReviewText = fk.Lorem.Text(), Id = 2 },
                new Review() { CustomerId = 3, ReviewDate = DateTime.Now.AddDays(-fk.Random.Int()), ProductId = 3, Rating = 4, ReviewText = fk.Lorem.Text(), Id = 3 },
                new Review() { CustomerId = 2, ReviewDate = DateTime.Now.AddDays(-fk.Random.Int()), ProductId = 4, Rating = 3, ReviewText = fk.Lorem.Text(), Id = 4 },
                new Review() { CustomerId = 2, ReviewDate = DateTime.Now.AddDays(-fk.Random.Int()), ProductId = 5, Rating = 2, ReviewText = fk.Lorem.Text(), Id = 5 },
                new Review() { CustomerId = 1, ReviewDate = DateTime.Now.AddDays(-fk.Random.Int()), ProductId = 6, Rating = 4, ReviewText = fk.Lorem.Text(), Id = 6 }
                    );
        }
    }
}
