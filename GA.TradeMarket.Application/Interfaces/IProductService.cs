using GA.TradeMarket.Application.Models;
using GA.TradeMarket.Application.Models.RequestModels;

namespace GA.TradeMarket.Application.Interfaces
{

    public interface IProductService : Icrud<ProductModel,ProductModelIn>
    {
        Task<List<ProductModel>> GetByFilterAsync(FilterSearchModel serch);
        Task UpdateCategoryAsync(ProductCategoryModelIn mod);
        Task RemoveCategoryAsync(long a);
        Task AddCategoryAsync(ProductCategoryModelIn mod);
        Task<IEnumerable<ProductCategoryModel>> GetAllProductCategoriesAsync();
    }

}
