using AutoMapper;
using GA.TradeMarket.Application.Interfaces;
using GA.TradeMarket.Application.Models;
using GA.TradeMarket.Application.Validation;
using GA.TradeMarket.Infrastructure.UniteOfWorkRelated;

namespace GA.TradeMarket.Application.Services
{
    public class StatisticService :AbstractService, IStatisticService
    {

        public StatisticService(IUnitOfWork obj, IMapper mapper):base(obj,mapper)
        {
        }

        public async Task<List<ProductModel>> GetCustomersMostPopularProductsAsync(int productCount, long customerId)
        {
            var allreceipts = await obj.ReceiptRepository.GetAllWithDetailsAsync();

            var selectedProducts = allreceipts
                .Where(io => io.order.CustomerId == customerId)
                .OrderByDescending(io => io.ReceiptDetails?.Sum(detail => detail.Quantity))
                .SelectMany(io => io.ReceiptDetails.Select(detail => detail.Product))
                .Take(productCount);

            var mapp = mapper.Map<List<ProductModel>>(selectedProducts);
            return mapp;
        }

        public async Task<decimal> GetIncomeOfCategoryInPeriod(long categoryId, DateTime startDate, DateTime endDate)
        {
            if (startDate >= endDate || startDate >= DateTime.Now || endDate >= DateTime.Now)
            {
                throw new MarketException("Invalid date range.");
            }

            var details = await obj.ReceiptRepository.GetAllWithDetailsAsync();

            var filteredByDate = details.Where(io => io.order.OrderDate >= startDate && io.order.OrderDate <= endDate);

            var filtered = filteredByDate
                .SelectMany(io => io.ReceiptDetails)
                .Where(detail => detail.Product != null && detail.Product.ProductCategoryId == categoryId);

            var totalIncome = filtered.Sum(detail => detail.DiscountUnitPrice * detail.Quantity);

            return totalIncome;
        }


        public async Task<List<ProductModel>> GetMostPopularProductsAsync(int productCount)
        {
            var receipdetails = await obj.ReceiptDetailRepository.GetAllWithDetailsAsync();
            var products = receipdetails.OrderByDescending(io => io.Quantity).Select(io => io.Product);
            var res = products.Take(productCount);
            var mapped = mapper.Map<List<ProductModel>>(res);
            return mapped;
        }

        public async Task<List<CustomerActivityModel>> GetMostValuableCustomersAsync(int customerCount, DateTime startDate, DateTime endDate)
        {

            if (startDate >= endDate || startDate >= DateTime.Now || endDate >= DateTime.Now)
            {
                throw new MarketException("Invalid date range.");
            }

            var receipts = await obj.ReceiptRepository.GetAllWithDetailsAsync();

            var filteredReceipts = receipts.Where(io => io.order.OrderDate >= startDate && io.order.OrderDate <= endDate);

            var groupedReceiptsByCustomer = filteredReceipts.GroupBy(io => io.order.Customer);
 
            var customerActivities = groupedReceiptsByCustomer
                .Select(group => new CustomerActivityModel
                {
                    CustomerId = group.Key.Id,
                    CustomerName = $"{group.Key.Person.Name} {group.Key.Person.Surname}",
                    ReceiptSum = group.Sum(io => io.ReceiptDetails.Sum(detail => detail.DiscountUnitPrice * detail.Quantity))
                })
                .OrderByDescending(activity => activity.ReceiptSum)
                .ToList();
            var topCustomers = customerActivities.Take(customerCount).ToList();

            return topCustomers;
        }
    }

}
