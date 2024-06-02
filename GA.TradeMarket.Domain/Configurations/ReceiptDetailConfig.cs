﻿using Bogus;
using GA.TradeMarket.Domain.Entitites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GA.TradeMarket.Domain.Configurations
{
    public class ReceiptDetailConfig : IEntityTypeConfiguration<ReceiptDetail>
    {
        public void Configure(EntityTypeBuilder<ReceiptDetail> builder)
        {
            Bogus.Faker fk = new Bogus.Faker();
            Random ran=new Random();
            builder.HasData(
                new ReceiptDetail() { DiscountUnitPrice =ran.Next(40, 1000), ProductId = 1, Quantity = ran.Next(10,100), UnitPrice = fk.Finance.Amount(), ReceiptId = 1, Id = 1 },
                new ReceiptDetail() { DiscountUnitPrice = ran.Next(40, 1000), ProductId = 2, Quantity = ran.Next(10, 100), UnitPrice = fk.Finance.Amount(), ReceiptId = 3, Id = 2 },
                new ReceiptDetail() { DiscountUnitPrice = ran.Next(40, 1000), ProductId = 3, Quantity = ran.Next(10, 100), UnitPrice = fk.Finance.Amount(), ReceiptId = 2, Id = 3 },
                new ReceiptDetail() { DiscountUnitPrice = ran.Next(40, 1000), ProductId = 4, Quantity = ran.Next(10, 100), UnitPrice = fk.Finance.Amount(), ReceiptId = 3, Id = 4 },
                new ReceiptDetail() { DiscountUnitPrice = ran.Next(40, 1000), ProductId = 5, Quantity = ran.Next(10, 100), UnitPrice = fk.Finance.Amount(), ReceiptId = 4, Id = 5 },
                new ReceiptDetail() { DiscountUnitPrice = ran.Next(40, 1000), ProductId = 1, Quantity = ran.Next(10, 100), UnitPrice = fk.Finance.Amount(), ReceiptId = 5, Id = 6 },
                new ReceiptDetail() { DiscountUnitPrice = ran.Next(40, 1000), ProductId = 2, Quantity = ran.Next(10, 100), UnitPrice = fk.Finance.Amount(), ReceiptId = 2, Id = 7 },
                new ReceiptDetail() { DiscountUnitPrice = ran.Next(40, 1000), ProductId = 3, Quantity = ran.Next(10, 100), UnitPrice = fk.Finance.Amount(), ReceiptId = 3, Id = 8 },
                new ReceiptDetail() { DiscountUnitPrice = ran.Next(40, 1000), ProductId = 4, Quantity = ran.Next(10, 100), UnitPrice = fk.Finance.Amount(), ReceiptId = 2, Id = 9 },
                new ReceiptDetail() { DiscountUnitPrice = ran.Next(40, 1000), ProductId = 5, Quantity = ran.Next(10, 100), UnitPrice = fk.Finance.Amount(), ReceiptId = 3, Id = 10 }
 
                );
        }
    }
}
