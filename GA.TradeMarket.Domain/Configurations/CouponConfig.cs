using GA.TradeMarket.Domain.Entitites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GA.TradeMarket.Domain.Configurations
{
    public class CouponConfig : IEntityTypeConfiguration<Coupon>
    {
        public void Configure(EntityTypeBuilder<Coupon> builder)
        {
            Bogus.Faker fk = new Bogus.Faker();
            Random rand=new Random();
            builder.HasData(
                new Coupon() { Id = 1, DiscountValue = rand.Next(100,400), ExpiryDate = DateTime.Now.AddDays(rand.Next(10, 500)), Code =fk.Finance.BitcoinAddress()+$"{rand.Next(100,100000)}"},
                 new Coupon() { Id = 2, DiscountValue = rand.Next(100, 400), ExpiryDate = DateTime.Now.AddDays(rand.Next(10, 500)), Code = fk.Finance.BitcoinAddress()+$"{rand.Next(100, 100000)}" },
                  new Coupon() { Id = 3, DiscountValue = rand.Next(100, 400), ExpiryDate = DateTime.Now.AddDays(rand.Next(10, 500)), Code = fk.Finance.BitcoinAddress() + $"{rand.Next(100, 100000)}" },
                   new Coupon() { Id = 4, DiscountValue = rand.Next(100, 400), ExpiryDate = DateTime.Now.AddDays(rand.Next(10, 500)), Code = fk.Finance.BitcoinAddress()+ $"{rand.Next(100, 100000)}" },
                    new Coupon() { Id = 5, DiscountValue = rand.Next(100, 400), ExpiryDate = DateTime.Now.AddDays(rand.Next(10, 500)), Code = fk.Finance.BitcoinAddress() + $"{rand.Next(100, 100000)}" },
                     new Coupon() { Id = 6, DiscountValue = rand.Next(100, 400), ExpiryDate = DateTime.Now.AddDays(rand.Next(10, 500)), Code = fk.Finance.BitcoinAddress()+ $"{rand.Next(100, 100000)}" },
                      new Coupon() { Id = 7, DiscountValue = rand.Next(100, 400), ExpiryDate = DateTime.Now.AddDays(rand.Next(10, 500)), Code = fk.Finance.BitcoinAddress() + $"{rand.Next(100, 100000)}" },
                   new Coupon() { Id = 8, DiscountValue = rand.Next(100, 400), ExpiryDate = DateTime.Now.AddDays(rand.Next(10, 500)), Code = fk.Finance.BitcoinAddress()+ $"{rand.Next(100, 100000)}" },
                    new Coupon() { Id = 9, DiscountValue = rand.Next(100, 400), ExpiryDate = DateTime.Now.AddDays(rand.Next(10, 500)), Code = fk.Finance.BitcoinAddress() + $"{rand.Next(100, 100000)}" },
                 new Coupon() { Id = 10, DiscountValue = rand.Next(100, 400), ExpiryDate = DateTime.Now.AddDays(rand.Next(10, 500)), Code = fk.Finance.BitcoinAddress() + $"{rand.Next(100, 100000)}" },
                  new Coupon() { Id = 11, DiscountValue = rand.Next(100, 400), ExpiryDate = DateTime.Now.AddDays(rand.Next(10, 500)), Code = fk.Finance.BitcoinAddress() + $"{rand.Next(100, 100000)}" },
                   new Coupon() { Id = 12, DiscountValue = rand.Next(100, 400), ExpiryDate = DateTime.Now.AddDays(rand.Next(10, 500)), Code = fk.Finance.BitcoinAddress() + $"{rand.Next(100, 100000)}" },
                    new Coupon() { Id = 13, DiscountValue = rand.Next(100, 400), ExpiryDate = DateTime.Now.AddDays(rand.Next(10, 500)), Code = fk.Finance.BitcoinAddress() + $"{rand.Next(100, 100000)}" },
                     new Coupon() { Id = 14, DiscountValue = rand.Next(100, 400), ExpiryDate = DateTime.Now.AddDays(rand.Next(10, 500)), Code = fk.Finance.BitcoinAddress() + $"{rand.Next(100, 100000)}" },
                      new Coupon() { Id = 15, DiscountValue = rand.Next(100, 400), ExpiryDate = DateTime.Now.AddDays(rand.Next(10, 500)), Code = fk.Finance.BitcoinAddress() + $"{rand.Next(100, 100000)}" },
                   new Coupon() { Id = 16, DiscountValue = rand.Next(100, 400), ExpiryDate = DateTime.Now.AddDays(rand.Next(10, 500)), Code = fk.Finance.BitcoinAddress() + $"{rand.Next(100, 100000)}" }
                );
        }
    }       
}
