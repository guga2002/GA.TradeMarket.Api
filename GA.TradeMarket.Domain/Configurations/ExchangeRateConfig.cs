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

                 new ExchangeRate { Id = 1, Currency = "GEL", Buy = 1.0m, Sell = 1.0m, LogTime = DateTime.Now }
                );
        }
    }
}
