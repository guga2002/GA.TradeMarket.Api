using GA.TradeMarket.Domain.Entitites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GA.TradeMarket.Domain.Configurations
{
    public class ExchangeRateConfig : IEntityTypeConfiguration<ExchangeRate>
    {
        public void Configure(EntityTypeBuilder<ExchangeRate> builder)
        {
            builder.HasData(

                 new ExchangeRate { Id = 1, Currency = "USD", Buy = 2.7m, Sell = 2.8m, LogTime = DateTime.Now },
                  new ExchangeRate { Id = 2, Currency = "EUR", Buy = 2.9m, Sell = 2.85m, LogTime = DateTime.Now },
                   new ExchangeRate { Id = 3, Currency = "GBP", Buy = 2.65m, Sell = 2.85m, LogTime = DateTime.Now }
                );
        }
    }
}
