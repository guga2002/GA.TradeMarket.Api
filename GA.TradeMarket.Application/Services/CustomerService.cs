using AutoMapper;
using GA.TradeMarket.Application.Interfaces;
using GA.TradeMarket.Application.Models;
using GA.TradeMarket.Application.Models.RequestModels;
using GA.TradeMarket.Application.StaticFIles;
using GA.TradeMarket.Application.Validation;
using GA.TradeMarket.Domain.Entitites;
using GA.TradeMarket.Infrastructure.UniteOfWorkRelated;

namespace GA.TradeMarket.Application.Services
{
    public class CustomerService : AbstractService, ICustomerService
    {

        public CustomerService(IUnitOfWork obj, IMapper mapper) : base(obj, mapper)
        {
        }

        public async Task AddAsync(CustomerReqModel item)
        {
            if (item == null)
            {
                throw new MarketException(ErrorKeys.InternalServerError);
            }
            if (item.BirthDate > DateTime.Now.AddYears(-10) || item.BirthDate <= new DateTime(1890, 1, 1, 1, 1, 1, DateTimeKind.Utc))
            {
                throw new MarketException(ErrorKeys.DateValidation);
            }

            if (!string.IsNullOrEmpty(item.Name) && !string.IsNullOrEmpty(item.Surname))
            {
                var mapped = mapper.Map<Customer>(item);

                await obj.CustomerRepository.AddAsync(mapped);
                await obj.SaveAsync();
            }
            else
            {
                throw new MarketException(ErrorKeys.InternalServerError);
            }
        }

        public async Task DeleteAsync(long item)
        {
            try
            {
                if (item <= 0)
                {
                    throw new MarketException(ErrorKeys.BadRequest);
                }
                await obj.CustomerRepository.DeleteByIdAsync(item);
                await obj.SaveAsync();
            }
            catch (Exception)
            {
                throw new MarketException(ErrorKeys.InternalServerError);
            }
        }

        public async Task<IEnumerable<CustomerModel>> GetAllWithDetailsAsync()
        {
            var res = await obj.CustomerRepository.GetAllWithDetailsAsync();
            if (res == null) throw new MarketException(ErrorKeys.InternalServerError);
            var mapped = mapper.Map<IEnumerable<CustomerModel>>(res);
            if (mapped == null) throw new MarketException(ErrorKeys.InternalServerError);
            return mapped;
        }

        public async Task<CustomerModel> GetByIdAsync(long Id)
        {
            var res = await obj.CustomerRepository.GetByIdAsync(Id);
            if (res == null) throw new MarketException(ErrorKeys.InternalServerError);
            var mapped = mapper.Map<CustomerModel>(res);
            if (mapped == null) throw new MarketException(ErrorKeys.InternalServerError);
            return mapped;
        }

        public async Task<IEnumerable<CustomerModel>> GetCustomersByProductIdAsync(long id)
        {
            if (id <= 0) throw new MarketException(ErrorKeys.InternalServerError);
            var res = await obj.CustomerRepository.GetAllWithDetailsAsync();
            if (res != null)
            {
                var axal = res.Where(io => io.bonuses
                            .Any(rd => rd.Id == id))
              .ToList();
                if (axal.Count == 0)
                {
                    throw new MarketException(ErrorKeys.BadRequest);
                }
                var mapped = mapper.Map<IEnumerable<CustomerModel>>(axal);
                if (mapped == null) throw new MarketException(ErrorKeys.mapped);

                return mapped;
            }
            throw new MarketException(ErrorKeys.General);
        }

        public async Task UpdateAsync(CustomerReqModel item)
        {

            if (item.BirthDate >= DateTime.Now || item.BirthDate <= new DateTime(1890, 1, 1, 1, 1, 1, DateTimeKind.Utc))
            {
                throw new MarketException(ErrorKeys.DateValidation);
            }
            if (string.IsNullOrEmpty(item.Name) || string.IsNullOrEmpty(item.Surname))
            {
                throw new MarketException(ErrorKeys.BadRequest);
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