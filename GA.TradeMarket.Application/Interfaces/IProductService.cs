using GA.TradeMarket.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA.TradeMarket.Application.Interfaces
{

    public interface IProductService : Icrud<ProductModel>
    {
        Task<List<ProductModel>> GetByFilterAsync(FilterSearchModel serch);
        Task UpdateCategoryAsync(ProductCategoryModel mod);
        Task RemoveCategoryAsync(long a);
        Task AddCategoryAsync(ProductCategoryModel mod);
        Task<IEnumerable<ProductCategoryModel>> GetAllProductCategoriesAsync();
    }

}
