using GA.TradeMarket.Application.Models;

namespace GA.TradeMarket.Application.Interfaces
{
    public interface IStatisticService
    {
        Task<List<ProductModel>> GetMostPopularProductsAsync(int productCount);
        Task<List<ProductModel>> GetCustomersMostPopularProductsAsync(int productCount, long customerId);
        Task<decimal> GetIncomeOfCategoryInPeriod(IncomeOfCategoryModel mod);
        Task<List<CustomerActivityModel>> GetMostValuableCustomersAsync(StatisticShipperModel mod);
        Task<IEnumerable<ShippingModelStatistic>> PopularShiper(StatisticShipperModel mod);
    }

}
