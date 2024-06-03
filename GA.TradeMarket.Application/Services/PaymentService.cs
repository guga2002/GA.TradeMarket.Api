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
    public class PaymentService : AbstractService,IPaymentService
    {
        public PaymentService(IUnitOfWork obj, IMapper map) : base(obj, map)
        {
        }

        public async Task AddAsync(PaymentModelIn item)
        {
          ArgumentNullException.ThrowIfNull(item, nameof(item));
            if(item.Amount<0) throw new ArgumentNullException(nameof(item.Amount));
            var order=await obj.OrderRepository.GetByIdAsync(item.OrderId);
           var method= await obj.PaymentMethodRepository.GetByIdAsync(item.paymentMethodId);
            if(order is null || method is null)
            {
                throw new NoItemFoundException(ErrorKeys.NoOrder);
            }
            var mapped = mapper.Map<Payment>(item);
            if(mapped is not null)
            {
               await obj.PaymentRepository.AddAsync(mapped);
            }
            throw new ArgumentException(ErrorKeys.mapped);
        }

        public async Task AddPaymentMethodAsync(PaymentMethodModelIn mod)
        {
            ArgumentNullException.ThrowIfNull(mod, nameof(mod));
            if (mod.ExpiryDate >DateTime.Now) throw new ArgumentNullException(nameof(mod.ExpiryDate));
            var customer=await obj.CustomerRepository.GetByIdAsync(mod.Id);
            if(customer is null)
            {
                throw new ArgumentNullException(ErrorKeys.NoCustommer);
            }
            var mapped = mapper.Map<PaymentMethod>(mod);
            if (mapped is not null)
            {
                await obj.PaymentMethodRepository.AddAsync(mapped);
            }
            throw new ArgumentException(ErrorKeys.mapped);
        }

        public async Task DeleteAsync(long item)
        {
            await obj.PaymentRepository.DeleteByIdAsync(item);
        }

        public async Task<IEnumerable<PaymentModel>> GetAllWithDetailsAsync()
        {
           var res= await obj.PaymentRepository.GetAllWithDetailsAsync();
            if(res.Any())
            {
                var mapped=mapper.Map<IEnumerable<PaymentModel>>(res);
                if(mapped.Any())
                {
                    return mapped;
                }
            }
            throw new NoItemFoundException(ErrorKeys.NotFound);
        }

        public async Task<IEnumerable<PaymentMethodModel>> GetAllPaymentMethodAsync()
        {
            var res = await obj.PaymentMethodRepository.GetAllWithDetailsAsync();
            if (res.Any())
            {
                var mapped = mapper.Map<IEnumerable<PaymentMethodModel>>(res);
                if (mapped.Any())
                {
                    return mapped;
                }
            }
            throw new NoItemFoundException(ErrorKeys.NotFound);
        }

        public async Task<PaymentModel> GetByIdAsync(long Id)
        {
            var payment = await obj.PaymentRepository.GetByIdAsync(Id);
            if (payment is not null)
            {
                var mapped = mapper.Map<PaymentModel>(payment);
                return mapped;
            }
            throw new MarketException(ErrorKeys.NotFound);
        }

        public async Task RemovePayMentMethodAsync(long a)
        {
            await obj.PaymentMethodRepository.DeleteByIdAsync(a);
        }

        public async Task UpdateAsync(PaymentModelIn item)
        {
            ArgumentNullException.ThrowIfNull(item, nameof(item));
            if (item.Amount < 0) throw new ArgumentNullException(nameof(item.Amount));
            var method = await obj.PaymentMethodRepository.GetByIdAsync(item.paymentMethodId);
            if (method is null)
            {
                throw new NoItemFoundException(ErrorKeys.NotFound);
            }
            var mapped = mapper.Map<Payment>(item);
            if (mapped is not null)
            {
                 obj.PaymentRepository.Update(mapped);
            }
            await obj.SaveAsync();
            throw new ArgumentException(ErrorKeys.mapped);
        }

        public async Task UpdatePaymentMethodAsync(PaymentMethodModelIn mod)
        {

            ArgumentNullException.ThrowIfNull(mod, nameof(mod));
            if (mod.ExpiryDate > DateTime.Now) throw new ArgumentNullException(nameof(mod.ExpiryDate));
            var customer = await obj.CustomerRepository.GetByIdAsync(mod.Id);
            if (customer is null)
            {
                throw new ArgumentNullException(ErrorKeys.NoCustommer);
            }
            var mapped = mapper.Map<PaymentMethod>(mod);
            if (mapped is not null)
            {
                 obj.PaymentMethodRepository.Update(mapped);
            }
            await obj.SaveAsync();
            throw new ArgumentException(ErrorKeys.mapped);
        }
    }
}
