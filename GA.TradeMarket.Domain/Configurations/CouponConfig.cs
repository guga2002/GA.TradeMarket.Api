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
    public class CouponConfig : IEntityTypeConfiguration<Coupon>
    {
        public void Configure(EntityTypeBuilder<Coupon> builder)
        {
            Faker fk = new Faker();
            Random rand=new Random();
            builder.HasData(
                new Coupon() { Id = 1, DiscountValue = fk.Finance.Amount(), ExpiryDate = DateTime.Now.AddDays(rand.Next(10, 500)), Code =fk.Finance.BitcoinAddress()},
                 new Coupon() { Id = 2, DiscountValue = fk.Finance.Amount(), ExpiryDate = DateTime.Now.AddDays(rand.Next(10, 500)), Code = fk.Finance.BitcoinAddress() },
                  new Coupon() { Id = 3, DiscountValue = fk.Finance.Amount(), ExpiryDate = DateTime.Now.AddDays(rand.Next(10, 500)), Code = fk.Finance.BitcoinAddress() },
                   new Coupon() { Id = 4, DiscountValue = fk.Finance.Amount(), ExpiryDate = DateTime.Now.AddDays(rand.Next(10, 500)), Code = fk.Finance.BitcoinAddress() },
                    new Coupon() { Id = 5, DiscountValue = fk.Finance.Amount(), ExpiryDate = DateTime.Now.AddDays(rand.Next(10, 500)), Code = fk.Finance.BitcoinAddress() },
                     new Coupon() { Id = 6, DiscountValue = fk.Finance.Amount(), ExpiryDate = DateTime.Now.AddDays(rand.Next(10, 500)), Code = fk.Finance.BitcoinAddress() },
                      new Coupon() { Id = 7, DiscountValue = fk.Finance.Amount(), ExpiryDate = DateTime.Now.AddDays(rand.Next(10, 500)), Code = fk.Finance.BitcoinAddress() },
                   new Coupon() { Id = 8, DiscountValue = fk.Finance.Amount(), ExpiryDate = DateTime.Now.AddDays(rand.Next(10, 500)), Code = fk.Finance.BitcoinAddress() }
                );
        }
    }       
}
