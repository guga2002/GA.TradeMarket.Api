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
    public class ShippingService : AbstractService, IShippingService
    {
        public ShippingService(IUnitOfWork obj, IMapper map) : base(obj, map)
        {
        }

        public async Task AddAsync(ShippingModelIn item)
        {
           ArgumentNullException.ThrowIfNull(item,nameof(item));
            if(string.IsNullOrEmpty(item.TrackingNumber))
            {
                throw new ArgumentNullException(nameof(item.TrackingNumber));
            }
            var order= await obj.OrderRepository.GetByIdAsync(item.OrderId);
            if(order is null)
            {
                throw new NoItemFoundException(nameof(item));
            }
            var mapped= mapper.Map<Shipping>(item);
            if(mapped is not null)
            {
               await  obj.ShipingRepository.AddAsync(mapped);
            }
        }

        public async Task AddNotificationAsync(NotificationModelIn mod)
        {
            ArgumentNullException.ThrowIfNull(mod, nameof(mod));
            if (string.IsNullOrEmpty(mod.Message))
            {
                throw new ArgumentNullException(nameof(mod.Message));
            }
            var order = await obj.OrderRepository.GetByIdAsync(mod.UserId);
            if (order is null)
            {
                throw new NoItemFoundException(nameof(order));
            }
            var mapped = mapper.Map<Notification>(mod);
            if (mapped is not null)
            {
                await obj.NotificationRepository.AddAsync(mapped);
                await obj.SaveAsync();
            }
        }

        public async Task DeleteAsync(long item)
        {
           await obj.ShipingRepository.DeleteByIdAsync(item);
        }

        public async Task<IEnumerable<ShippingModel>> GetAllWithDetailsAsync()
        {
            var res = await obj.ShipingRepository.GetAllWithDetailsAsync();
            if(res.Any())
            {
                var mapped = mapper.Map<IEnumerable<ShippingModel>>(res);
                return mapped;
            }
            throw new NoItemFoundException(ErrorKeys.NotFound);
        }

        public async Task<IEnumerable<NotificationModel>> GetAllNotificationAsync()
        {
            var res = await obj.NotificationRepository.GetAllWithDetailsAsync();
            if (res.Any())
            {
                var mapped = mapper.Map<IEnumerable<NotificationModel>>(res);
                return mapped;
            }
            throw new NoItemFoundException(ErrorKeys.NotFound);
        }

        public async Task<ShippingModel> GetByIdAsync(long Id)
        {
            var res = await obj.ShipingRepository.GetByIdAsync(Id);
            if (res is not null)
            {
                var mapped = mapper.Map<ShippingModel>(res);
                return mapped;
            }
            throw new NoItemFoundException(ErrorKeys.NotFound);
        }

        public async Task RemoveNotificationAsync(long a)
        {
            await obj.NotificationRepository.DeleteByIdAsync(a);
        }

        public async Task UpdateAsync(ShippingModelIn item)
        {
            ArgumentNullException.ThrowIfNull(item, nameof(item));
            if (string.IsNullOrEmpty(item.TrackingNumber))
            {
                throw new ArgumentNullException(nameof(item.TrackingNumber));
            }
            var order = await obj.OrderRepository.GetByIdAsync(item.OrderId);
            if (order is null)
            {
                throw new NoItemFoundException(nameof(item));
            }
            var mapped = mapper.Map<Shipping>(item);
            if (mapped is not null)
            {
                 obj.ShipingRepository.Update(mapped);
                await obj.SaveAsync();
            }
        }

        public async Task UpdateNotificationAsync(NotificationModelIn mod)
        {
            ArgumentNullException.ThrowIfNull(mod, nameof(mod));
            if (string.IsNullOrEmpty(mod.Message))
            {
                throw new ArgumentNullException(nameof(mod.Message));
            }
            var order = await obj.OrderRepository.GetByIdAsync(mod.UserId);
            if (order is null)
            {
                throw new NoItemFoundException(nameof(order));
            }
            var mapped = mapper.Map<Notification>(mod);
            if (mapped is not null)
            {
                obj.NotificationRepository.Update(mapped);
                await obj.SaveAsync();
            }
        }
    }
}
