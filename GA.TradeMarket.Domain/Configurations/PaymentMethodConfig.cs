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
                new PaymentMethod() { CardHolderName = fk.Finance.AccountName(), CardNumber = fk.Finance.CreditCardNumber(), CVV = fk.Finance.CreditCardCvv(), ExpiryDate = DateTime.Now.AddYears(rnd.Next(2, 10)), Id = 1 },
                new PaymentMethod() { CardHolderName = fk.Finance.AccountName(), CardNumber = fk.Finance.CreditCardNumber(), CVV = fk.Finance.CreditCardCvv(), ExpiryDate = DateTime.Now.AddYears(rnd.Next(2, 10)), Id = 2 },
                 new PaymentMethod() { CardHolderName = fk.Finance.AccountName(), CardNumber = fk.Finance.CreditCardNumber(), CVV = fk.Finance.CreditCardCvv(), ExpiryDate = DateTime.Now.AddYears(rnd.Next(2, 10)), Id = 3 },
                  new PaymentMethod() { CardHolderName = fk.Finance.AccountName(), CardNumber = fk.Finance.CreditCardNumber(), CVV = fk.Finance.CreditCardCvv(), ExpiryDate = DateTime.Now.AddYears(rnd.Next(2, 10)), Id = 4 },
                   new PaymentMethod() { CardHolderName = fk.Finance.AccountName(), CardNumber = fk.Finance.CreditCardNumber(), CVV = fk.Finance.CreditCardCvv(), ExpiryDate = DateTime.Now.AddYears(rnd.Next(2, 10)), Id = 5 },
                    new PaymentMethod() { CardHolderName = fk.Finance.AccountName(), CardNumber = fk.Finance.CreditCardNumber(), CVV = fk.Finance.CreditCardCvv(), ExpiryDate = DateTime.Now.AddYears(rnd.Next(2, 10)), Id = 6 },
                    new PaymentMethod() { CardHolderName = fk.Finance.AccountName(), CardNumber = fk.Finance.CreditCardNumber(), CVV = fk.Finance.CreditCardCvv(), ExpiryDate = DateTime.Now.AddYears(rnd.Next(2, 10)), Id = 7 },
                    new PaymentMethod() { CardHolderName = fk.Finance.AccountName(), CardNumber = fk.Finance.CreditCardNumber(), CVV = fk.Finance.CreditCardCvv(), ExpiryDate = DateTime.Now.AddYears(rnd.Next(2, 10)), Id = 8 },
                    new PaymentMethod() { CardHolderName = fk.Finance.AccountName(), CardNumber = fk.Finance.CreditCardNumber(), CVV = fk.Finance.CreditCardCvv(), ExpiryDate = DateTime.Now.AddYears(rnd.Next(2, 10)), Id = 9 },
                    new PaymentMethod() { CardHolderName = fk.Finance.AccountName(), CardNumber = fk.Finance.CreditCardNumber(), CVV = fk.Finance.CreditCardCvv(), ExpiryDate = DateTime.Now.AddYears(rnd.Next(2, 10)), Id = 10 },
                    new PaymentMethod() { CardHolderName = fk.Finance.AccountName(), CardNumber = fk.Finance.CreditCardNumber(), CVV = fk.Finance.CreditCardCvv(), ExpiryDate = DateTime.Now.AddYears(rnd.Next(2, 10)), Id = 11 }

                );
        }
    }
}
