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
    public class AfterSoldService : AbstractService, IAfterSoldService
    {
        public AfterSoldService(IUnitOfWork obj, IMapper map) : base(obj, map)
        {
        }

        public async Task AddAsync(ReturnRequestModelIn item)
        {
            ArgumentNullException.ThrowIfNull(item, nameof(item));
            var order = await obj.OrderRepository.GetByIdAsync(item.OrderId);
            if (order is null)
            {
                throw new NoItemFoundException(ErrorKeys.NoOrder);
            }
            var mapped=mapper.Map<ReturnRequest>(order);
            if(mapped is not null)
            {
               await  obj.ReturnRequestRepository.AddAsync(mapped);
            }
        }

        public async Task AddReviewAsync(ReviewModelIn mod)
        {
            ArgumentNullException.ThrowIfNull(mod, nameof(mod));
            var product = await obj.ProductRepository.GetByIdAsync(mod.ProductId);
            if (product is null)
            {
                throw new NoItemFoundException(ErrorKeys.NoOrder);
            }
            var customer= await obj.CustomerRepository.GetByIdAsync(mod.CustomerId);
            if (customer is null)
            {
                throw new NoItemFoundException(ErrorKeys.NoCustommer);
            }
            var mapped = mapper.Map<Review>(mod);
            if (mapped is not null)
            {
                await obj.reviewRepository.AddAsync(mapped);
            }
        }

        public async Task DeleteAsync(long item)
        {
            await obj.ReturnRequestRepository.DeleteByIdAsync(item);
        }

        public async Task<IEnumerable<ReturnRequestModel>> GetAllWithDetailsAsync()
        {
            var returnreq = await obj.ReturnRequestRepository.GetAllWithDetailsAsync();
            if(returnreq.Any())
            {
                var mapped=mapper.Map<IEnumerable<ReturnRequestModel>>(returnreq);
                return mapped;
            }
            throw new NoItemFoundException(ErrorKeys.NotFound);
        }

        public async Task<IEnumerable<ReviewModel>> GetAllReviewsAsync()
        {
            var returnreq = await obj.reviewRepository.GetAllWithDetailsAsync();
            if (returnreq.Any())
            {
                var mapped = mapper.Map<IEnumerable<ReviewModel>>(returnreq);
                return mapped;
            }
            throw new NoItemFoundException(ErrorKeys.NotFound);
        }

        public async Task<ReturnRequestModel> GetByIdAsync(long Id)
        {
            var returnreq = await obj.ReturnRequestRepository.GetByIdAsync(Id);
            if (returnreq is not null)
            {
                var mapped = mapper.Map<ReturnRequestModel>(returnreq);
                return mapped;
            }
            throw new NoItemFoundException(ErrorKeys.NotFound);
        }

        public async Task RemoveReviewAsync(long a)
        {
            await obj.reviewRepository.DeleteByIdAsync(a);
        }

        public async Task UpdateAsync(ReturnRequestModelIn item)
        {
            ArgumentNullException.ThrowIfNull(item, nameof(item));
            var order = await obj.OrderRepository.GetByIdAsync(item.OrderId);
            if (order is null)
            {
                throw new NoItemFoundException(ErrorKeys.NoOrder);
            }
            var mapped = mapper.Map<ReturnRequest>(order);
            if (mapped is not null)
            {
                obj.ReturnRequestRepository.Update(mapped);
            }
        }

        public async Task UpdateReviewAsync(ReviewModelIn mod)
        {
            ArgumentNullException.ThrowIfNull(mod, nameof(mod));
            var product = await obj.ProductRepository.GetByIdAsync(mod.ProductId);
            if (product is null)
            {
                throw new NoItemFoundException(ErrorKeys.NoOrder);
            }
            var customer = await obj.CustomerRepository.GetByIdAsync(mod.CustomerId);
            if (customer is null)
            {
                throw new NoItemFoundException(ErrorKeys.NoCustommer);
            }
            var mapped = mapper.Map<Review>(mod);
            if (mapped is not null)
            {
                obj.reviewRepository.Update(mapped);
            }
        }
    }
}
