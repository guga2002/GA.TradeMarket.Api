using GA.TradeMarket.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA.TradeMarket.Application.Interfaces
{
    public interface ICustomerService : Icrud<CustomerModel>
    {
        Task<IEnumerable<CustomerModel>> GetCustomersByProductIdAsync(long id);
    }

}
