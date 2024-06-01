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
    public class CouponConfig : IEntityTypeConfiguration<Coupon>
    {
        public void Configure(EntityTypeBuilder<Coupon> builder)
        {
            Random rand=new Random();
            builder.HasData(
                new Coupon() { Id = 1, DiscountValue = 45, ExpiryDate = DateTime.Now.AddDays(rand.Next(10, 500)), Code = $"GE3434{rand.Next(10, 567)}34435" },
                 new Coupon() { Id = 2, DiscountValue = 467, ExpiryDate = DateTime.Now.AddDays(rand.Next(10, 500)), Code = $"GE3434{rand.Next(10, 567)}34435" },
                  new Coupon() { Id = 3, DiscountValue = 457, ExpiryDate = DateTime.Now.AddDays(rand.Next(10, 500)), Code = $"GE3434{rand.Next(10, 567)}34435" },
                   new Coupon() { Id = 4, DiscountValue = 48, ExpiryDate = DateTime.Now.AddDays(rand.Next(10, 500)), Code = $"GE3434{rand.Next(10, 567)}34435" },
                    new Coupon() { Id = 5, DiscountValue = 45, ExpiryDate = DateTime.Now.AddDays(rand.Next(10, 500)), Code = $"GE3434{rand.Next(10, 567)}34435" },
                     new Coupon() { Id = 6, DiscountValue = 25, ExpiryDate = DateTime.Now.AddDays(rand.Next(10, 500)), Code = $"GE3434{rand.Next(10, 567)}34435" },
                      new Coupon() { Id = 7, DiscountValue = 15, ExpiryDate = DateTime.Now.AddDays(rand.Next(10, 500)), Code = $"GE3434{rand.Next(10, 567)}34435" },
                   new Coupon() { Id = 8, DiscountValue = 78, ExpiryDate = DateTime.Now.AddDays(rand.Next(10, 500)), Code = $"GE3434{rand.Next(10, 567)}34435" }
                );
        }
    }
}
