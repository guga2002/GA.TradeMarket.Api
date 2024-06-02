using GA.TradeMarket.Domain.Entitites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GA.TradeMarket.Domain.Configurations
{
    public class BonusProgramConfig : IEntityTypeConfiguration<BonusProgram>
    {
        public void Configure(EntityTypeBuilder<BonusProgram> builder)
        {
            Random rand = new Random();
            builder.HasData(
                new BonusProgram() { CustomerId = 1, EnrollmentDate = DateTime.Now.AddYears(-rand.Next(1, 30)), Points = rand.Next(100, 1000), Id = 1 },
                 new BonusProgram() { CustomerId = 2, EnrollmentDate = DateTime.Now.AddYears(-rand.Next(1, 30)), Points = rand.Next(100, 1000), Id = 2 },
                  new BonusProgram() { CustomerId = 2, EnrollmentDate = DateTime.Now.AddYears(-rand.Next(1, 30)), Points = rand.Next(100, 1000), Id = 3 },
                   new BonusProgram() { CustomerId = 3, EnrollmentDate = DateTime.Now.AddYears(-rand.Next(1, 30)), Points = rand.Next(100, 1000), Id = 4 },
                    new BonusProgram() { CustomerId = 4, EnrollmentDate = DateTime.Now.AddYears(-rand.Next(1, 30)), Points = rand.Next(100, 1000), Id = 5 },
                     new BonusProgram() { CustomerId = 1, EnrollmentDate = DateTime.Now.AddYears(-rand.Next(1, 30)), Points = rand.Next(100, 1000), Id = 6 },
                      new BonusProgram() { CustomerId = 1, EnrollmentDate = DateTime.Now.AddYears(-rand.Next(1, 30)), Points = rand.Next(100, 1000), Id = 7 },
                       new BonusProgram() { CustomerId = 2, EnrollmentDate = DateTime.Now.AddYears(-rand.Next(1, 30)), Points = rand.Next(100, 1000), Id = 8 },
                        new BonusProgram() { CustomerId = 3, EnrollmentDate = DateTime.Now.AddYears(-rand.Next(1, 30)), Points = rand.Next(100, 1000), Id = 9 },
                         new BonusProgram() { CustomerId = 2, EnrollmentDate = DateTime.Now.AddYears(-rand.Next(1, 30)), Points = rand.Next(100, 1000), Id = 10 },
                          new BonusProgram() { CustomerId = 4, EnrollmentDate = DateTime.Now.AddYears(-rand.Next(1, 30)), Points = rand.Next(100, 1000), Id = 11 },
                           new BonusProgram() { CustomerId = 1, EnrollmentDate = DateTime.Now.AddYears(-rand.Next(1, 30)), Points = rand.Next(100, 1000), Id = 12 },
                            new BonusProgram() { CustomerId = 2, EnrollmentDate = DateTime.Now.AddYears(-rand.Next(1, 30)), Points = rand.Next(100, 1000), Id = 13 },
                             new BonusProgram() { CustomerId = 4, EnrollmentDate = DateTime.Now.AddYears(-rand.Next(1, 30)), Points = rand.Next(100, 1000), Id = 14 },
                              new BonusProgram() { CustomerId = 2, EnrollmentDate = DateTime.Now.AddYears(-rand.Next(1, 30)), Points = rand.Next(100, 1000), Id = 15 },
                           new BonusProgram() { CustomerId = 2, EnrollmentDate = DateTime.Now.AddYears(-rand.Next(1, 30)), Points = rand.Next(100, 1000), Id = 16 }
                );
        }
    }
}
