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
    public class ReturmRequestConfig : IEntityTypeConfiguration<ReturnRequest>
    {
        public void Configure(EntityTypeBuilder<ReturnRequest> builder)
        {
            Faker fk = new Faker();
            builder.HasData(

                new ReturnRequest() { RequestDate = DateTime.Now.AddDays(-fk.Random.Int()), OrderId = 1, Reason = fk.Lorem.Text(), Status = "Active", Id = 1 },
                new ReturnRequest() { RequestDate = DateTime.Now.AddDays(-fk.Random.Int()), OrderId = 2, Reason = fk.Lorem.Text(), Status = "Passed", Id = 2 },
                new ReturnRequest() { RequestDate = DateTime.Now.AddDays(-fk.Random.Int()), OrderId = 3, Reason = fk.Lorem.Text(), Status = "Declined", Id = 3 }
                );
        }
    }
}
