using GA.TradeMarket.Application.Models;

namespace GA.TradeMarket.Application.Interfaces
{
    public interface IStatisticService
    {
        Task<List<ProductModel>> GetMostPopularProductsAsync(int productCount);
        Task<List<CustomerActivityModel>> GetMostValuableCustomersAsync(int customerCount, DateTime startDate, DateTime endDate);
        Task<List<ProductModel>> GetCustomersMostPopularProductsAsync(int productCount, int customerId);
        Task<decimal> GetIncomeOfCategoryInPeriod(long categoryId, DateTime startDate, DateTime endDate);
    }

}
