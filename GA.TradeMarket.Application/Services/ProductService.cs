using AutoMapper;
using GA.TradeMarket.Application.Interfaces;
using GA.TradeMarket.Application.Models;
using GA.TradeMarket.Application.Validation;
using GA.TradeMarket.Domain.Entitites;
using GA.TradeMarket.Infrastructure.UniteOfWorkRelated;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GA.TradeMarket.Application.Services
{
    public class ProductService : AbstractService, IProductService
    {


        public ProductService(IUnitOfWork obje, IMapper mapper) : base(obje, mapper)
        {
        }

        public async Task AddAsync(ProductModel item)
        {

            if (string.IsNullOrEmpty(item.ProductName))
            {
                throw new MarketException("shecdomaa");
            }
            if (item.Price < 0)
            {
                throw new MarketException("shecdoma");
            }
            if (obj.ProductRepository != null)
            {
                var mapped = mapper.Map<Product>(item);
                await obj.ProductRepository.AddAsync(mapped);
                await obj.SaveAsync();
            }
            else
            {
                throw new ArgumentException("it is null there");
            }
        }

        public async Task AddCategoryAsync(ProductCategoryModel mod)
        {
            if (mod == null || string.IsNullOrEmpty(mod.CategoryName) || mod.Id < 0)
            {
                throw new MarketException("shecdomaaa");
            }
            else
            {
                var mapped = mapper.Map<ProductCategory>(mod);

                await obj.ProductCategoryRepository.AddAsync(mapped);
                await obj.SaveAsync();
            }
        }

        public async Task DeleteAsync(long item)
        {
            if (item <= 0) throw new MarketException("kide");
            await obj.ProductRepository.DeleteByIdAsync(item);
            await obj.SaveAsync();
        }

        public async Task<IEnumerable<ProductModel>> GetAllAsync()
        {
            var res = await obj.ProductRepository.GetAllWithDetailsAsync();
            var mapped = mapper.Map<IEnumerable<ProductModel>>(res);
            return mapped;
        }

        public async Task<IEnumerable<ProductCategoryModel>> GetAllProductCategoriesAsync()
        {
            var res = await obj.ProductCategoryRepository.GetAllAsync();
            if (res == null) throw new MarketException("shecdoma");
            var mapped = mapper.Map<IEnumerable<ProductCategoryModel>>(res);
            return mapped;
        }

        public async Task<List<ProductModel>> GetByFilterAsync(FilterSearchModel serch)
        {
            var allProducts = await obj.ProductRepository.GetAllWithDetailsAsync();

            var filteredProducts = allProducts.Where(p => p.ProductCategoryId == serch.CategoryId);
            if (serch.MinPrice.HasValue)
            {
                filteredProducts = filteredProducts.Where(p => p.Price >= serch.MinPrice.Value);
            }
            if (serch.MinPrice.HasValue && !serch.CategoryId.HasValue)
            {
                var all = allProducts.Where(p => p.Price >= serch.MinPrice.Value);

                List<ProductModel> producdif = new List<ProductModel>();
                foreach (var item in all)
                {
                    var prod = new ProductModel()
                    {
                        CategoryName = item.Category.CategoryName,
                        Price = item.Price,
                        ProductName = item.ProductName,
                        ProductCategoryId = item.ProductCategoryId,
                        Id = item.Id,
                    };
                    producdif.Add(prod);
                }
                return producdif;

            }
            if (serch.MaxPrice.HasValue)
            {
                filteredProducts = filteredProducts.Where(p => p.Price <= serch.MaxPrice.Value);
            }

            if (serch.MaxPrice.HasValue && serch.MinPrice.HasValue)
            {
                filteredProducts = filteredProducts.Where(p => p.Price <= serch.MaxPrice.Value && p.Price >= serch.MinPrice.Value);
            }
            List<ProductModel> products = new List<ProductModel>();
            foreach (var item in filteredProducts)
            {
                if (item.Category != null)
                {
                    var prod = new ProductModel()
                    {
                        CategoryName = item.Category.CategoryName,
                        Price = item.Price,
                        ProductName = item.ProductName,
                        ProductCategoryId = item.ProductCategoryId,
                        Id = item.Id,
                    };
                    products.Add(prod);
                }
            }
            return products;

        }

        public async Task<ProductModel> GetByIdAsync(long Id)
        {
            var res = await obj.ProductRepository.GetByIdWithDetailsAsync(Id);
            var mapped = mapper.Map<ProductModel>(res);
            return mapped;
        }

        public async Task RemoveCategoryAsync(long a)
        {
            await obj.ProductCategoryRepository.DeleteByIdAsync(a);
            await obj.SaveAsync();
        }

        public async Task UpdateAsync(ProductModel item)
        {
            if (item == null || string.IsNullOrEmpty(item.ProductName))
            {
                throw new MarketException("ProductModel cannot be null and ProductName cannot be empty.");
            }
            else
            {
                var mappedProduct = mapper.Map<Product>(item);
                obj.ProductRepository.Update(mappedProduct);
                await obj.SaveAsync();
            }
        }

        public async Task UpdateCategoryAsync(ProductCategoryModel mod)
        {
            if (mod == null || string.IsNullOrEmpty(mod.CategoryName))
            {
                throw new MarketException("There is null");
            }
            else
            {
                var mapped = mapper.Map<ProductCategory>(mod);
                obj.ProductCategoryRepository.Update(mapped);
                await obj.SaveAsync();
            }
        }

    }
}
