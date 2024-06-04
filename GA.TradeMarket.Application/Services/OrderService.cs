﻿using AutoMapper;
using GA.TradeMarket.Application.Interfaces;
using GA.TradeMarket.Application.Models;
using GA.TradeMarket.Application.Models.RequestModels;
using GA.TradeMarket.Application.StaticFIles;
using GA.TradeMarket.Application.Validation;
using GA.TradeMarket.Domain.Entitites;
using GA.TradeMarket.Infrastructure.UniteOfWorkRelated;

namespace GA.TradeMarket.Application.Services
{
    public class OrderService : AbstractService, IOrderService
    {
        public OrderService(IUnitOfWork obj, IMapper map) : base(obj, map)
        {
        }

        public async Task AddAsync(OrderModelIn item)
        {
          ArgumentNullException.ThrowIfNull(item, nameof(item));
           var custommer = await obj.CustomerRepository.GetByIdAsync(item.CustomerId);
            if(custommer is null)
            {
                throw new TradeMarket.Application.Validation.MarketException(ErrorKeys.NoCustommer);
            }
            var mapped = mapper.Map<Order>(item);
            await obj.OrderRepository.AddAsync(mapped);
        }

        public async Task DeleteAsync(long item)
        {
           await obj.OrderRepository.DeleteByIdAsync(item);
        }

        public async Task<IEnumerable<OrderModel>> GetAllWithDetailsAsync()
        {
           var res=await obj.OrderRepository.GetAllWithDetailsAsync();
            if(res.Any())
            {
                var mapped= mapper.Map<IEnumerable<OrderModel>>(res);
                return mapped;
            }
            throw new MarketException(ErrorKeys.NotFound);
        }

        public async Task<OrderModel> GetByIdAsync(long Id)
        {
            var res = await obj.OrderRepository.GetByIdAsync(Id);
            if(res is not null)
            {
                var  mapped=mapper.Map<OrderModel>(res);
                return mapped;
            }
            throw new MarketException(ErrorKeys.NotFound);
        }

        public async Task UpdateAsync(OrderModelIn item)
        {
            ArgumentNullException.ThrowIfNull(item, nameof(item));
            var custommer = await obj.CustomerRepository.GetByIdAsync(item.CustomerId);
            if (custommer is null)
            {
                throw new TradeMarket.Application.Validation.MarketException(ErrorKeys.NoCustommer);
            }
            var mapped = mapper.Map<Order>(item);
            obj.OrderRepository.Update(mapped);
        }

        public async Task<string> CheckStatus(long orderId)
        {
            var order = await  obj.OrderRepository.GetByIdAsync(orderId);
            if(order is not null)
            {
                return order.Status;
            }
            throw new ArgumentException("No order Exist on this Id");
        }

        public async Task UpdateStatus(UpdateStatusModelIn ord)
        {
            ArgumentNullException.ThrowIfNull(ord, nameof(ord));
            var order = await obj.OrderRepository.GetByIdAsync(ord.OrderId);
            if (order is not null)
            {
                order.Status=ord.Status;
                await obj.SaveAsync();
            }
        }
    }
}
