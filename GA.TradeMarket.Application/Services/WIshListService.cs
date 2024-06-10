using AutoMapper;
using GA.TradeMarket.Application.Interfaces;
using GA.TradeMarket.Application.Models;
using GA.TradeMarket.Application.Models.RequestModels;
using GA.TradeMarket.Application.StaticFIles;
using GA.TradeMarket.Application.Validation;
using GA.TradeMarket.Domain.Entitites;
using GA.TradeMarket.Infrastructure.UniteOfWorkRelated;
using Microsoft.AspNetCore.Identity;
using System.Runtime.Intrinsics.X86;

namespace GA.TradeMarket.Application.Services
{
    public class WIshListService : AbstractService, IWishListService
    {
        private readonly UserManager<Person> _userManager;
        public WIshListService(IUnitOfWork obj, IMapper map,UserManager<Person> usrm) : base(obj, map)
        {
            this._userManager = usrm;
        }

        public async Task AddAsync(WishListModelIn item)
        {
            try
            {
                ArgumentNullException.ThrowIfNull(item, ErrorKeys.ArgumentNull);
                var product = await obj.ProductRepository.GetByIdAsync(item.productId);
                if (product == null) { throw new MarketException(ErrorKeys.NoProduct); }
                var customer = await obj.CustomerRepository.GetByIdAsync(item.CustomerId);
                if (customer == null) { throw new MarketException(ErrorKeys.NoCustommer); }
                var mapped = mapper.Map<WIshList>(item);
                if (mapped == null) { throw new MarketException(ErrorKeys.mapped); }
                await obj.WishListRepository.AddAsync(mapped);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task DeleteAsync(long item)
        {
            try
            {
                await obj.WishListRepository.DeleteByIdAsync(item);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<IEnumerable<WishListModel>> GetAllWithDetailsAsync(string username)
        {
            try
            {
                var use=await _userManager.FindByNameAsync(username);
                if(use == null||use.Customer is null)
                {
                    throw new UnauthorizedAccessException(username);
                }
                var res = await obj.WishListRepository.GetAllWithDetailsAsync();
                if (res.Any())
                {
                    var mapped = mapper.Map<IEnumerable<WishListModel>>(res);
                    if (mapped == null) throw new MarketException(ErrorKeys.mapped);
                    return mapped.Where(io=>io.CustomerId==use.Customer.Id).ToList();
                }
                throw new NoItemFoundException(ErrorKeys.NotFound);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<IEnumerable<WishListModel>> GetAllWithDetailsAsync()
        {
            try
            {
                var res = await obj.WishListRepository.GetAllWithDetailsAsync();
                if (res.Any())
                {
                    var mapped = mapper.Map<IEnumerable<WishListModel>>(res);
                    if (mapped == null) throw new MarketException(ErrorKeys.mapped);
                    return mapped;
                }
                throw new NoItemFoundException(ErrorKeys.NotFound);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<WishListModel> GetByIdAsync(long Id)
        {
            try
            {
                var res = await obj.WishListRepository.GetByIdAsync(Id);
                if (res is not null)
                {
                    var mapped = mapper.Map<WishListModel>(res);
                    if (mapped == null) throw new MarketException(ErrorKeys.mapped);
                    return mapped;
                }
                throw new NoItemFoundException(ErrorKeys.NotFound);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task UpdateAsync(WishListModelIn item)
        {
            try
            {
                ArgumentNullException.ThrowIfNull(item, ErrorKeys.ArgumentNull);
                var product = await obj.ProductRepository.GetByIdAsync(item.productId);
                if (product == null) { throw new MarketException(ErrorKeys.NoProduct); }
                var customer = await obj.CustomerRepository.GetByIdAsync(item.CustomerId);
                if (customer == null) { throw new MarketException(ErrorKeys.NoCustommer); }
                var mapped = mapper.Map<WIshList>(item);
                if (mapped == null) { throw new MarketException(ErrorKeys.mapped); }
                 obj.WishListRepository.Update(mapped);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
