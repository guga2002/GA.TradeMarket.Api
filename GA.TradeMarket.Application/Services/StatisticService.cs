using AutoMapper;
using GA.TradeMarket.Application.Interfaces;
using GA.TradeMarket.Application.Models;
using GA.TradeMarket.Application.StaticFIles;
using GA.TradeMarket.Application.Validation;
using GA.TradeMarket.Infrastructure.UniteOfWorkRelated;
using System.Collections.Generic;

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

        public async Task<decimal> GetIncomeOfCategoryInPeriod(IncomeOfCategoryModel mod)
        {
            if (mod.start >= mod.end || mod.end >= DateTime.Now || mod.start >= DateTime.Now)
            {
                throw new MarketException(ErrorKeys.General);
            }

            var details = await obj.ReceiptRepository.GetAllWithDetailsAsync();

            var filteredByDate = details.Where(io => io.order.OrderDate >= mod.start && io.order.OrderDate <= mod.end);

            var filtered = filteredByDate
                .SelectMany(io => io.ReceiptDetails)
                .Where(detail => detail.Product != null && detail.Product.ProductCategoryId == mod.CategoryId);

            var totalIncome = filtered.Sum(detail => detail.DiscountUnitPrice * detail.Quantity);

            return totalIncome;
        }


        public async Task<List<ProductModel>> GetMostPopularProductsAsync(int productCount)
        {
            var receipdetails = await obj.ReceiptDetailRepository.GetAllWithDetailsAsync();
            var products = receipdetails.OrderByDescending(io => io.Product.Price).Select(io => io.Product);
            var res = products.Take(productCount);
            var mapped = mapper.Map<List<ProductModel>>(res);
            return mapped;
        }

        public async Task<List<CustomerActivityModel>> GetMostValuableCustomersAsync(StatisticShipperModel mod)
        {

            if (mod.start >= mod.end || mod.start >= DateTime.Now || mod.end >= DateTime.Now)
            {
                throw new MarketException(ErrorKeys.General);
            }

            var receipts = await obj.ReceiptRepository.GetAllWithDetailsAsync();

            var filteredReceipts = receipts.Where(io => io.order.OrderDate >= mod.start && io.order.OrderDate <= mod.end&&io.order.Customer is not null&&io.ReceiptDetails is not null);

            var groupedReceiptsByCustomer = filteredReceipts.GroupBy(io => io.order.Customer);
 
            var customerActivities = groupedReceiptsByCustomer
                .Select(group => new CustomerActivityModel
                {
                    CustomerId = group.Key.Id,
                    ReceiptSum = group.Sum(io => io.ReceiptDetails.Sum(detail => detail.DiscountUnitPrice * detail.Quantity))
                })
                .OrderByDescending(activity => activity.ReceiptSum)
                .ToList();
            var topCustomers = customerActivities.Take(mod.Count).ToList();

            return topCustomers;
        }

        public async Task<IEnumerable<ShippingModelStatistic>> PopularShiper(StatisticShipperModel mod)
        {
            var shipping = await obj.OrderRepository.GetAllWithDetailsAsync();

            var filteredReceipts = shipping.Where(io => io.OrderDate >= mod.start && io.OrderDate <= mod.end&&io.Shipping is not null);

            var grouped= filteredReceipts.GroupBy(io => io.Shipping);

            var selectedlist = grouped.Select(io => new ShippingModelStatistic()
            {
                shipingdetails = new ShippingModel()
                {
                    ShippingDate = io.Key.ShippingDate,
                    Carrier = io.Key.Carrier,
                    OrderId = io.Key.OrderId,
                    Status = io.Key.Status,
                    TrackingNumber = io.Key.TrackingNumber,
                },
                Count = io.Key.Order.Receipts.Count()
            }).OrderByDescending(io=>io.Count).ToList();

            return selectedlist.Take(mod.Count).ToList();
        }
    }

}