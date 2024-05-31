using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA.TradeMarket.Domain.Interfaces
{
    public interface ICrudRep<T> where T : class
    {
        Task<T> GetByIdAsync(int Id);

        Task<IEnumerable<T>> GetAllAsync();

        Task AddAsync(T customer);

        Task DeleteByIdAsync(int Id);

        Task<T> GetByIdWithDetailsAsync(int Id);

        Task<IEnumerable<T>> GetAllWithDetailsAsync();

        void Update(T custom);
    }

}
