using GA.TradeMarket.Domain.Entitites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GA.TradeMarket.Domain.Configurations
{
    public class ReturmRequestConfig : IEntityTypeConfiguration<ReturnRequest>
    {
        public void Configure(EntityTypeBuilder<ReturnRequest> builder)
        {
            Bogus.Faker fk = new Bogus.Faker();
            builder.HasData(

                new ReturnRequest() { RequestDate = DateTime.Now.AddDays(-30), OrderId = 1, Reason = fk.Lorem.Text(), Status = "Active", Id = 1},
                new ReturnRequest() { RequestDate = DateTime.Now.AddDays(-100), OrderId = 2, Reason = fk.Lorem.Text(), Status = "Passed", Id = 2 },
                new ReturnRequest() { RequestDate = DateTime.Now.AddDays(-20), OrderId = 3, Reason = fk.Lorem.Text(), Status = "Declined", Id = 3 },
                    new ReturnRequest() { RequestDate = DateTime.Now.AddDays(-30), OrderId = 4, Reason = fk.Lorem.Text(), Status = "Processing", Id = 4 },
                new ReturnRequest() { RequestDate = DateTime.Now.AddDays(-100), OrderId = 5, Reason = fk.Lorem.Text(), Status = "To be ready", Id = 5 },
                new ReturnRequest() { RequestDate = DateTime.Now.AddDays(-20), OrderId = 6, Reason = fk.Lorem.Text(), Status = "Archived", Id = 6 }
                );
        }
    }
}
