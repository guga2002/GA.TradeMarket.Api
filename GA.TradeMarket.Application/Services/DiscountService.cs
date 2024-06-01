﻿using AutoMapper;
using GA.TradeMarket.Application.Interfaces;
using GA.TradeMarket.Application.Models;
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

        public async Task AddAsync(BonusProgramModel item)
        {
           ArgumentNullException.ThrowIfNull(item, nameof(item));
            var customer = await obj.CustomerRepository.GetByIdAsync(item.CustomerId);
            if(customer is null)
            {
                throw new NoUserExistException(" no such a Customer exist");
            }
            var map = mapper.Map<BonusProgram>(item);
            await obj.bonusProgramRepository.AddAsync(map);
        }

        public async Task AddCouponAsync(CouponModel mod)
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

        public async Task<IEnumerable<BonusProgramModel>> GetAllAsync()
        {
            var res= await obj.bonusProgramRepository.GetAllAsync();
            if(res.Any())
            {
                var  mapped= mapper.Map<IEnumerable<BonusProgramModel>>(res);
                if(mapped.Any())
                {
                    return mapped;
                }
            }
            throw new NoItemFoundException("No bonuses  exist!");
        }

        public async Task<IEnumerable<CouponModel>> GetAllCouponAsync()
        {
            var res = await obj.CouponRepository.GetAllAsync();
            if (res.Any())
            {
                var mapped = mapper.Map<IEnumerable<CouponModel>>(res);
                if (mapped.Any())
                {
                    return mapped;
                }
            }
            throw new NoItemFoundException("No coupons  exist!");
        }

        public async Task<BonusProgramModel> GetByIdAsync(long Id)
        {
            var bonus=await obj.bonusProgramRepository.GetByIdAsync(Id);
            if(bonus is not  null)
            {
                var mapped=mapper.Map<BonusProgramModel>(bonus);
                return mapped;
            }
            throw new NoItemFoundException("No item exist");
        }

        public async Task RemoveCouponAsync(long a)
        {
            await obj.CouponRepository.DeleteByIdAsync(a);
        }

        public async Task UpdateAsync(BonusProgramModel item)
        {
           ArgumentNullException.ThrowIfNull(item, "item");
            if(item.EnrollmentDate>DateTime.Now||item.EnrollmentDate< new DateTime(1933,01,01))
            {
                throw new MarketException(" Datetime is not correct!");
            }
            var mapped=mapper.Map<BonusProgram>(item);
            if (mapped is not null) 
            obj.bonusProgramRepository.Update(mapped);
            await obj.SaveAsync();
        }

        public async Task UpdateCouponAsync(CouponModel mod)
        {
            ArgumentNullException.ThrowIfNull(mod, "mod");
            if (mod.ExpiryDate>DateTime.Now)
            {
                throw new MarketException(" Datetime is not correct!");
            }
            var mapped = mapper.Map<Coupon>(mod);
            if (mapped is not null)
                obj.CouponRepository.Update(mapped);
            await obj.SaveAsync();
        }
    }
}