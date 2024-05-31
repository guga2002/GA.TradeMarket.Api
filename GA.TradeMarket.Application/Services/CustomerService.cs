using AutoMapper;
using GA.TradeMarket.Application.Interfaces;
using GA.TradeMarket.Application.Models;
using GA.TradeMarket.Application.Validation;
using GA.TradeMarket.Domain.Entitites;
using GA.TradeMarket.Infrastructure.UniteOfWorkRelated;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA.TradeMarket.Application.Services
{
    public class CustomerService : AbstractService, ICustomerService
    {

        public CustomerService(IUnitOfWork obj, IMapper mapper) : base(obj, mapper)
        {
        }

        public async Task AddAsync(CustomerModel item)
        {
            if (item == null)
            {
                throw new MarketException("exct");
            }
            if (item.BirthDate >= DateTime.Now || item.BirthDate <= new DateTime(1890, 1, 1, 1, 1, 1, DateTimeKind.Utc))
            {
                throw new MarketException("Tarigi");
            }
            if (!string.IsNullOrEmpty(item.Name) && !string.IsNullOrEmpty(item.Surname))
            {
                var mapped = mapper.Map<Customer>(item);

                await obj.CustomerRepository.AddAsync(mapped);
                await obj.SaveAsync();
            }
            else
            {
                throw new MarketException("shecdoma");
            }
        }

        public async Task DeleteAsync(long item)
        {
            try
            {
                if (item <= 0)
                {
                    throw new MarketException("shecdoma");
                }
                await obj.CustomerRepository.DeleteByIdAsync(item);
                await obj.SaveAsync();
            }
            catch (Exception)
            {
                throw new MarketException("shecdoma");
            }
        }

        public async Task<IEnumerable<CustomerModel>> GetAllAsync()
        {
            var res = await obj.CustomerRepository.GetAllWithDetailsAsync();
            if (res == null) throw new MarketException("Shecdoma");
            var mapped = mapper.Map<IEnumerable<CustomerModel>>(res);
            if (mapped == null) throw new MarketException("shecdoma");
            return mapped;
        }

        public async Task<CustomerModel> GetByIdAsync(long Id)
        {
            var res = await obj.CustomerRepository.GetByIdWithDetailsAsync(Id);
            if (res == null) throw new MarketException("Shecdoma");
            var mapped = mapper.Map<CustomerModel>(res);
            if (mapped == null) throw new MarketException("shecdoma");
            return mapped;
        }

        public async Task<IEnumerable<CustomerModel>> GetCustomersByProductIdAsync(long id)
        {
            if (id <= 0) throw new MarketException("error");
            var res = await obj.CustomerRepository.GetAllWithDetailsAsync();
            if (res != null)
            {
                var axal = res.Where(io => io.Receipts
                            .SelectMany(r => r.ReceiptDetails)
                            .Any(rd => rd.ProductId == id))
              .ToList();
                if (axal.Count == 0)
                {
                    throw new MarketException("shecdoma");
                }
                var mapped = mapper.Map<IEnumerable<CustomerModel>>(axal);
                if (mapped == null) throw new MarketException("shecdoma");

                return mapped;
            }
            throw new MarketException("shecdoma");
        }

        public async Task UpdateAsync(CustomerModel item)
        {

            if (item.BirthDate >= DateTime.Now || item.BirthDate <= new DateTime(1890, 1, 1, 1, 1, 1, DateTimeKind.Utc))
            {
                throw new MarketException("Datetime is wrong");
            }
            if (string.IsNullOrEmpty(item.Name) || string.IsNullOrEmpty(item.Surname))
            {
                throw new MarketException("There is error");
            }
            var res = mapper.Map<Customer>(item);
            if (obj.CustomerRepository != null)
            {
                obj.CustomerRepository.Update(res);
                await obj.SaveAsync();
            }
        }

    }
}