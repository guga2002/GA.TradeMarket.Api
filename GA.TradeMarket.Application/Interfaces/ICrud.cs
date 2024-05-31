using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA.TradeMarket.Application.Interfaces
{
    public interface Icrud<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(long Id);
        Task AddAsync(T item);
        Task DeleteAsync(long item);
        Task UpdateAsync(T item);
    }

}
