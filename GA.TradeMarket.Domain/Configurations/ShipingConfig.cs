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
    public class ShipingConfig : IEntityTypeConfiguration<Shipping>
    {
        public void Configure(EntityTypeBuilder<Shipping> builder)
        {
            Faker fk = new Faker();
            builder.HasData(
        new Shipping() { Id = 1, OrderId = 1, Status = "Sent from abroad", ShippingDate = DateTime.Now.AddDays(-fk.Random.Int()), TrackingNumber = fk.Finance.Bic(), Carrier = fk.Finance.BitcoinAddress() },
        new Shipping() { Id = 2, OrderId = 2, Status = "Recieved from abroad", ShippingDate = DateTime.Now.AddDays(-fk.Random.Int()), TrackingNumber = fk.Finance.Bic(), Carrier = fk.Finance.BitcoinAddress() },
        new Shipping() { Id = 3, OrderId = 3, Status = "recieve in sorting centre", ShippingDate = DateTime.Now.AddDays(-fk.Random.Int()), TrackingNumber = fk.Finance.Bic(), Carrier = fk.Finance.BitcoinAddress() },
        new Shipping() { Id = 4, OrderId = 4, Status = "delivered", ShippingDate = DateTime.Now.AddDays(-fk.Random.Int()), TrackingNumber = fk.Finance.Bic(), Carrier = fk.Finance.BitcoinAddress() },
        new Shipping() { Id = 5, OrderId = 5, Status = "Unsuccesfull delivery", ShippingDate = DateTime.Now.AddDays(-fk.Random.Int()), TrackingNumber = fk.Finance.Bic(), Carrier = fk.Finance.BitcoinAddress() },
        new Shipping() { Id = 6, OrderId = 6, Status = "recieved", ShippingDate = DateTime.Now.AddDays(-fk.Random.Int()), TrackingNumber = fk.Finance.Bic(), Carrier = fk.Finance.BitcoinAddress() },
        new Shipping() { Id = 7, OrderId = 7, Status = "boxing", ShippingDate = DateTime.Now.AddDays(-fk.Random.Int()), TrackingNumber = fk.Finance.Bic(), Carrier = fk.Finance.BitcoinAddress() });
        }
    }
}
