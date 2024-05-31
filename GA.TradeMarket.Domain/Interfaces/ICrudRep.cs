using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA.TradeMarket.Domain.Interfaces
{
    public interface ICrudRep<T> where T : class
    {
        Task<T> GetByIdAsync(long Id);

        Task<IEnumerable<T>> GetAllAsync();

        Task AddAsync(T customer);

        Task DeleteByIdAsync(long Id);

        Task<T> GetByIdWithDetailsAsync(long Id);

        Task<IEnumerable<T>> GetAllWithDetailsAsync();

        void Update(T custom);
    }

}
