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
    public class DiscountService : AbstractService, IDiscountService
    {
        public DiscountService(IUnitOfWork obj, IMapper map) : base(obj, map)
        {
        }

        public async Task AddAsync(BonusProgramModelIn item)
        {
           ArgumentNullException.ThrowIfNull(item, nameof(item));
            var customer = await obj.CustomerRepository.GetByIdAsync(item.CustomerId);
            if(customer is null)
            {
                throw new NoUserExistException(ErrorKeys.NoCustommer);
            }
            var map = mapper.Map<BonusProgram>(item);
            await obj.bonusProgramRepository.AddAsync(map);
        }

        public async Task AddCouponAsync(CouponModelIn mod)
        {
            ArgumentNullException.ThrowIfNull(mod, nameof(mod));
            if(string.IsNullOrEmpty(mod.Code)) { 
            
                throw new ArgumentNullException(nameof(mod));
            }
            var map = mapper.Map<Coupon>(mod);
            await obj.CouponRepository.AddAsync(map);
        }

        public async Task DeleteAsync(long item)
        {
            await obj.bonusProgramRepository.DeleteByIdAsync(item);
        }

        public async Task<IEnumerable<BonusProgramModel>> GetAllWithDetailsAsync()
        {
            var res= await obj.bonusProgramRepository.GetAllWithDetailsAsync();
            if(res.Any())
            {
                var  mapped= mapper.Map<IEnumerable<BonusProgramModel>>(res);
                if(mapped.Any())
                {
                    return mapped;
                }
            }
            throw new NoItemFoundException(ErrorKeys.NoBonus);
        }

        public async Task<IEnumerable<CouponModel>> GetAllCouponAsync()
        {
            var res = await obj.CouponRepository.GetAllWithDetailsAsync();
            if (res.Any())
            {
                var mapped = mapper.Map<IEnumerable<CouponModel>>(res);
                if (mapped.Any())
                {
                    return mapped;
                }
            }
            throw new NoItemFoundException(ErrorKeys.NoCoupon);
        }

        public async Task<BonusProgramModel> GetByIdAsync(long Id)
        {
            var bonus=await obj.bonusProgramRepository.GetByIdAsync(Id);
            if(bonus is not  null)
            {
                var mapped=mapper.Map<BonusProgramModel>(bonus);
                return mapped;
            }
            throw new NoItemFoundException(ErrorKeys.NotFound);
        }

        public async Task RemoveCouponAsync(long a)
        {
            await obj.CouponRepository.DeleteByIdAsync(a);
        }

        public async Task UpdateAsync(BonusProgramModelIn item)
        {
           ArgumentNullException.ThrowIfNull(item, ErrorKeys.ArgumentNull);
            if(item.EnrollmentDate>DateTime.Now||item.EnrollmentDate< new DateTime(1933,01,01))
            {
                throw new MarketException(ErrorKeys.DateValidation);
            }
            var mapped=mapper.Map<BonusProgram>(item);
            if (mapped is not null) 
            obj.bonusProgramRepository.Update(mapped);
            await obj.SaveAsync();
        }

        public async Task UpdateCouponAsync(CouponModelIn mod)
        {
            ArgumentNullException.ThrowIfNull(mod, ErrorKeys.ArgumentNull);
            if (mod.ExpiryDate>DateTime.Now)
            {
                throw new MarketException(ErrorKeys.DateValidation);
            }
            var mapped = mapper.Map<Coupon>(mod);
            if (mapped is not null)
                obj.CouponRepository.Update(mapped);
            await obj.SaveAsync();
        }
    }
}
