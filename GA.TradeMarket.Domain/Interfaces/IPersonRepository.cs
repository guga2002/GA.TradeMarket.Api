using GA.TradeMarket.Domain.Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA.TradeMarket.Domain.Interfaces
{
    public interface IPersonRepository
    {
        Task<Person> GetByIdAsync(string Id);

        Task<IEnumerable<Person>> GetAllAsync();

        Task AddAsync(Person customer);

        Task DeleteByIdAsync(string Id);

        Task<Person> GetByIdWithDetailsAsync(string Id);

        Task<IEnumerable<Person>> GetAllWithDetailsAsync();

        void Update(Person custom);
    }
}
