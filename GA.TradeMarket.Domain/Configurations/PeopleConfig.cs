using Bogus;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Person = GA.TradeMarket.Domain.Entitites.Person;

namespace GA.TradeMarket.Domain.Configurations
{
    public class PeopleConfig : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            Faker fk = new Faker();
            builder.HasData(
                new Person() { Id = "1", Email = fk.Person.Email, Surname = fk.Person.LastName, BirthDate = fk.Person.DateOfBirth, Name = fk.Person.FirstName, PhoneNumber = fk.Person.Phone, UserName = fk.Person.UserName },
         new Person() { Id = "2", Email = fk.Person.Email, Surname = fk.Person.LastName, BirthDate = fk.Person.DateOfBirth, Name = fk.Person.FirstName, PhoneNumber = fk.Person.Phone, UserName = fk.Person.UserName },
          new Person() { Id = "3", Email = fk.Person.Email, Surname = fk.Person.LastName, BirthDate = fk.Person.DateOfBirth, Name = fk.Person.FirstName, PhoneNumber = fk.Person.Phone, UserName = fk.Person.UserName },
           new Person() { Id = "4", Email = fk.Person.Email, Surname = fk.Person.LastName, BirthDate = fk.Person.DateOfBirth, Name = fk.Person.FirstName, PhoneNumber = fk.Person.Phone, UserName = fk.Person.UserName }
                );
        }
    }
}
