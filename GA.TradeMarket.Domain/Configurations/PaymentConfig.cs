using GA.TradeMarket.Domain.Entitites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GA.TradeMarket.Domain.Configurations
{
    public class PaymentConfig : IEntityTypeConfiguration<Payment>
    {
        public void Configure(EntityTypeBuilder<Payment> builder)
        {
            Random rnd = new Random();
            builder.HasData(
                  new Payment() { PaymentDate = DateTime.Now.AddDays(-rnd.Next(3, 30)), Amount = rnd.Next(30, 1000), OrderId = 1, paymentMethodId = 1, Id = 1 },
                  new Payment() { PaymentDate = DateTime.Now.AddDays(-rnd.Next(3, 30)), Amount = rnd.Next(30, 1000), OrderId = 2, paymentMethodId = 2, Id = 2 },
                  new Payment() { PaymentDate = DateTime.Now.AddDays(-rnd.Next(3, 30)), Amount = rnd.Next(30, 1000), OrderId = 3, paymentMethodId = 3, Id = 3 },
                  new Payment() { PaymentDate = DateTime.Now.AddDays(-rnd.Next(3, 30)), Amount = rnd.Next(30, 1000), OrderId = 4, paymentMethodId = 4, Id = 4 },
                  new Payment() { PaymentDate = DateTime.Now.AddDays(-rnd.Next(3, 30)), Amount = rnd.Next(30, 1000), OrderId = 5, paymentMethodId = 5, Id = 5 },
                  new Payment() { PaymentDate = DateTime.Now.AddDays(-rnd.Next(3, 30)), Amount = rnd.Next(30, 1000), OrderId = 1, paymentMethodId = 6, Id = 6 },
                  new Payment() { PaymentDate = DateTime.Now.AddDays(-rnd.Next(3, 30)), Amount = rnd.Next(30, 1000), OrderId = 3, paymentMethodId = 7, Id = 7 },
                  new Payment() { PaymentDate = DateTime.Now.AddDays(-rnd.Next(3, 30)), Amount = rnd.Next(30, 1000), OrderId = 2, paymentMethodId = 8, Id = 8 },
                  new Payment() { PaymentDate = DateTime.Now.AddDays(-rnd.Next(3, 30)), Amount = rnd.Next(30, 1000), OrderId = 3, paymentMethodId = 1, Id = 9 },
                  new Payment() { PaymentDate = DateTime.Now.AddDays(-rnd.Next(3, 30)), Amount = rnd.Next(30, 1000), OrderId = 4, paymentMethodId = 3, Id = 10 },
                  new Payment() { PaymentDate = DateTime.Now.AddDays(-rnd.Next(3, 30)), Amount = rnd.Next(30, 1000), OrderId = 5, paymentMethodId = 2, Id = 11 },
                  new Payment() { PaymentDate = DateTime.Now.AddDays(-rnd.Next(3, 30)), Amount = rnd.Next(30, 1000), OrderId = 2, paymentMethodId = 4, Id = 12 },
                  new Payment() { PaymentDate = DateTime.Now.AddDays(-rnd.Next(3, 30)), Amount = rnd.Next(30, 1000), OrderId = 3, paymentMethodId = 5, Id = 13 },
                  new Payment() { PaymentDate = DateTime.Now.AddDays(-rnd.Next(3, 30)), Amount = rnd.Next(30, 1000), OrderId = 1, paymentMethodId = 6, Id = 14 },
                  new Payment() { PaymentDate = DateTime.Now.AddDays(-rnd.Next(3, 30)), Amount = rnd.Next(30, 1000), OrderId = 6, paymentMethodId = 7, Id = 15 },
                  new Payment() { PaymentDate = DateTime.Now.AddDays(-rnd.Next(3, 30)), Amount = rnd.Next(30, 1000), OrderId = 7, paymentMethodId = 4, Id = 16},
                  new Payment() { PaymentDate = DateTime.Now.AddDays(-rnd.Next(3, 30)), Amount = rnd.Next(30, 1000), OrderId = 4, paymentMethodId = 5, Id = 17 },
                  new Payment() { PaymentDate = DateTime.Now.AddDays(-rnd.Next(3, 30)), Amount = rnd.Next(30, 1000), OrderId = 3, paymentMethodId = 3, Id = 7 }
                );
        }
    }
}
