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
           
            Random rand=new Random();
            builder.HasData(
                 new Person() { Id = "1", Email = Faker.Internet.Email(), Surname = Faker.Name.Last(), BirthDate = DateTime.Now.AddYears(-rand.Next(10,60)), Name = Faker.Name.Last(), PhoneNumber = Faker.Phone.Number(), UserName = Faker.Internet.UserName() },
                 new Person() { Id = "2", Email = Faker.Internet.Email(), Surname = Faker.Name.Last(), BirthDate = DateTime.Now.AddYears(-rand.Next(10, 60)), Name = Faker.Name.Last(), PhoneNumber = Faker.Phone.Number(), UserName = Faker.Internet.UserName() },
                 new Person() { Id = "3", Email = Faker.Internet.Email(), Surname =Faker.Name.Last(), BirthDate = DateTime.Now.AddYears(-rand.Next(10, 60)), Name = Faker.Name.Last(), PhoneNumber = Faker.Phone.Number(), UserName = Faker.Internet.UserName() },
                 new Person() { Id = "4", Email = Faker.Internet.Email(), Surname = Faker.Name.Last(), BirthDate = DateTime.Now.AddYears(-rand.Next(10, 60)), Name = Faker.Name.Last(), PhoneNumber = Faker.Phone.Number(), UserName = Faker.Internet.UserName() },
                 new Person() { Id = "5", Email = Faker.Internet.Email(), Surname = Faker.Name.Last(), BirthDate = DateTime.Now.AddYears(-rand.Next(10, 60)), Name = Faker.Name.Last(), PhoneNumber = Faker.Phone.Number(), UserName = Faker.Internet.UserName() },
                 new Person() { Id = "6", Email = Faker.Internet.Email(), Surname = Faker.Name.Last(), BirthDate = DateTime.Now.AddYears(-rand.Next(10, 60)), Name = Faker.Name.Last(), PhoneNumber = Faker.Phone.Number(), UserName = Faker.Internet.UserName() },
                 new Person() { Id = "7", Email = Faker.Internet.Email(), Surname = Faker.Name.Last(), BirthDate = DateTime.Now.AddYears(-rand.Next(10, 60)), Name = Faker.Name.Last(), PhoneNumber = Faker.Phone.Number(), UserName = Faker.Internet.UserName() },
                 new Person() { Id = "8", Email = Faker.Internet.Email(), Surname = Faker.Name.Last(), BirthDate = DateTime.Now.AddYears(-rand.Next(10, 60)), Name = Faker.Name.Last(), PhoneNumber = Faker.Phone.Number(), UserName = Faker.Internet.UserName() }
                );
        }
    }
}
