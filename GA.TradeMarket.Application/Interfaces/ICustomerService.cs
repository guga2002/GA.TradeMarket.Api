using GA.TradeMarket.Application.Models;
using GA.TradeMarket.Application.Models.RequestModels;

namespace GA.TradeMarket.Application.Interfaces
{
    public interface ICustomerService : Icrud<CustomerModel, CustomerReqModel>
    {
        Task<IEnumerable<CustomerModel>> GetCustomersByProductIdAsync(long id);
    }

}
