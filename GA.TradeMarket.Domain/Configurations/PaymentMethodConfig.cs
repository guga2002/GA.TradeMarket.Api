using Bogus;
using GA.TradeMarket.Domain.Entitites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GA.TradeMarket.Domain.Configurations
{
    public class PaymentMethodConfig : IEntityTypeConfiguration<PaymentMethod>
    {
        public void Configure(EntityTypeBuilder<PaymentMethod> builder)
        {
            Bogus.Faker fk = new Bogus.Faker();
            Random rnd = new Random();
            builder.HasData(
                new PaymentMethod() { CardHolderName = fk.Name.FullName(), CardNumber = fk.Finance.CreditCardNumber(), CVV = fk.Finance.CreditCardCvv(), ExpiryDate = DateTime.Now.AddYears(rnd.Next(2, 10)), Id = 1 },
                new PaymentMethod() { CardHolderName = fk.Name.FullName(), CardNumber = fk.Finance.CreditCardNumber(), CVV = fk.Finance.CreditCardCvv(), ExpiryDate = DateTime.Now.AddYears(rnd.Next(2, 10)), Id = 2 },
                 new PaymentMethod() { CardHolderName = fk.Name.FullName(), CardNumber = fk.Finance.CreditCardNumber(), CVV = fk.Finance.CreditCardCvv(), ExpiryDate = DateTime.Now.AddYears(rnd.Next(2, 10)), Id = 3 },
                  new PaymentMethod() { CardHolderName = fk.Name.FullName(), CardNumber = fk.Finance.CreditCardNumber(), CVV = fk.Finance.CreditCardCvv(), ExpiryDate = DateTime.Now.AddYears(rnd.Next(2, 10)), Id = 4 },
                   new PaymentMethod() { CardHolderName = fk.Name.FullName(), CardNumber = fk.Finance.CreditCardNumber(), CVV = fk.Finance.CreditCardCvv(), ExpiryDate = DateTime.Now.AddYears(rnd.Next(2, 10)), Id = 5 },
                    new PaymentMethod() { CardHolderName = fk.Name.FullName(), CardNumber = fk.Finance.CreditCardNumber(), CVV = fk.Finance.CreditCardCvv(), ExpiryDate = DateTime.Now.AddYears(rnd.Next(2, 10)), Id = 6 },
                    new PaymentMethod() { CardHolderName = fk.Name.FullName(), CardNumber = fk.Finance.CreditCardNumber(), CVV = fk.Finance.CreditCardCvv(), ExpiryDate = DateTime.Now.AddYears(rnd.Next(2, 10)), Id = 7 },
                    new PaymentMethod() { CardHolderName = fk.Name.FullName(), CardNumber = fk.Finance.CreditCardNumber(), CVV = fk.Finance.CreditCardCvv(), ExpiryDate = DateTime.Now.AddYears(rnd.Next(2, 10)), Id = 8 },
                    new PaymentMethod() { CardHolderName = fk.Name.FullName(), CardNumber = fk.Finance.CreditCardNumber(), CVV = fk.Finance.CreditCardCvv(), ExpiryDate = DateTime.Now.AddYears(rnd.Next(2, 10)), Id = 9 },
                    new PaymentMethod() { CardHolderName = fk.Name.FullName(), CardNumber = fk.Finance.CreditCardNumber(), CVV = fk.Finance.CreditCardCvv(), ExpiryDate = DateTime.Now.AddYears(rnd.Next(2, 10)), Id = 10 },
                    new PaymentMethod() { CardHolderName = fk.Name.FullName(), CardNumber = fk.Finance.CreditCardNumber(), CVV = fk.Finance.CreditCardCvv(), ExpiryDate = DateTime.Now.AddYears(rnd.Next(2, 10)), Id = 11 },
                    new PaymentMethod() { CardHolderName = fk.Name.FullName(), CardNumber = fk.Finance.CreditCardNumber(), CVV = fk.Finance.CreditCardCvv(), ExpiryDate = DateTime.Now.AddYears(rnd.Next(2, 10)), Id = 12 },
                    new PaymentMethod() { CardHolderName = fk.Name.FullName(), CardNumber = fk.Finance.CreditCardNumber(), CVV = fk.Finance.CreditCardCvv(), ExpiryDate = DateTime.Now.AddYears(rnd.Next(2, 10)), Id = 13 },
                    new PaymentMethod() { CardHolderName = fk.Name.FullName(), CardNumber = fk.Finance.CreditCardNumber(), CVV = fk.Finance.CreditCardCvv(), ExpiryDate = DateTime.Now.AddYears(rnd.Next(2, 10)), Id = 14 },
                    new PaymentMethod() { CardHolderName = fk.Name.FullName(), CardNumber = fk.Finance.CreditCardNumber(), CVV = fk.Finance.CreditCardCvv(), ExpiryDate = DateTime.Now.AddYears(rnd.Next(2, 10)), Id = 15 },
                    new PaymentMethod() { CardHolderName = fk.Name.FullName(), CardNumber = fk.Finance.CreditCardNumber(), CVV = fk.Finance.CreditCardCvv(), ExpiryDate = DateTime.Now.AddYears(rnd.Next(2, 10)), Id = 16 },
                    new PaymentMethod() { CardHolderName = fk.Name.FullName(), CardNumber = fk.Finance.CreditCardNumber(), CVV = fk.Finance.CreditCardCvv(), ExpiryDate = DateTime.Now.AddYears(rnd.Next(2, 10)), Id = 17 },
                    new PaymentMethod() { CardHolderName = fk.Name.FullName(), CardNumber = fk.Finance.CreditCardNumber(), CVV = fk.Finance.CreditCardCvv(), ExpiryDate = DateTime.Now.AddYears(rnd.Next(2, 10)), Id = 18 },
                    new PaymentMethod() { CardHolderName = fk.Name.FullName(), CardNumber = fk.Finance.CreditCardNumber(), CVV = fk.Finance.CreditCardCvv(), ExpiryDate = DateTime.Now.AddYears(rnd.Next(2, 10)), Id = 19 },
                    new PaymentMethod() { CardHolderName = fk.Name.FullName(), CardNumber = fk.Finance.CreditCardNumber(), CVV = fk.Finance.CreditCardCvv(), ExpiryDate = DateTime.Now.AddYears(rnd.Next(2, 10)), Id = 20 },
                    new PaymentMethod() { CardHolderName = fk.Name.FullName(), CardNumber = fk.Finance.CreditCardNumber(), CVV = fk.Finance.CreditCardCvv(), ExpiryDate = DateTime.Now.AddYears(rnd.Next(2, 10)), Id = 21 },
                    new PaymentMethod() { CardHolderName = fk.Name.FullName(), CardNumber = fk.Finance.CreditCardNumber(), CVV = fk.Finance.CreditCardCvv(), ExpiryDate = DateTime.Now.AddYears(rnd.Next(2, 10)), Id = 22 }
                );
        }
    }
}
