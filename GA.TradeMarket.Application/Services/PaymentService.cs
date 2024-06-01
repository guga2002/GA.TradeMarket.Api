using AutoMapper;
using GA.TradeMarket.Application.Interfaces;
using GA.TradeMarket.Application.Models;
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

        public async Task AddAsync(PaymentModel item)
        {
          ArgumentNullException.ThrowIfNull(item, nameof(item));
            if(item.Amount<0) throw new ArgumentNullException(nameof(item.Amount));
            var order=await obj.OrderRepository.GetByIdAsync(item.OrderId);
           var method= await obj.PaymentMethodRepository.GetByIdAsync(item.paymentMethodId);
            if(order is null || method is null)
            {
                throw new NoItemFoundException("No related Items found");
            }
            var mapped = mapper.Map<Payment>(item);
            if(mapped is not null)
            {
               await obj.PaymentRepository.AddAsync(mapped);
            }
            throw new ArgumentException("Mapping not was succesfully");
        }

        public async Task AddPaymentMethodAsync(PaymentMethodModel mod)
        {
            ArgumentNullException.ThrowIfNull(mod, nameof(mod));
            if (mod.ExpiryDate >DateTime.Now) throw new ArgumentNullException(nameof(mod.ExpiryDate));
            var customer=await obj.CustomerRepository.GetByIdAsync(mod.CustomerId);
            if(customer is null)
            {
                throw new ArgumentNullException("Custumer is Null");
            }
            var mapped = mapper.Map<PaymentMethod>(mod);
            if (mapped is not null)
            {
                await obj.PaymentMethodRepository.AddAsync(mapped);
            }
            throw new ArgumentException("Mapping not was succesfully");
        }

        public async Task DeleteAsync(long item)
        {
            await obj.PaymentRepository.DeleteByIdAsync(item);
        }

        public async Task<IEnumerable<PaymentModel>> GetAllAsync()
        {
           var res= await obj.PaymentRepository.GetAllAsync();
            if(res.Any())
            {
                var mapped=mapper.Map<IEnumerable<PaymentModel>>(res);
                if(mapped.Any())
                {
                    return mapped;
                }
            }
            throw new NoItemFoundException("No Entities found in Payment");
        }

        public async Task<IEnumerable<PaymentMethodModel>> GetAllPaymentMethodAsync()
        {
            var res = await obj.PaymentMethodRepository.GetAllAsync();
            if (res.Any())
            {
                var mapped = mapper.Map<IEnumerable<PaymentMethodModel>>(res);
                if (mapped.Any())
                {
                    return mapped;
                }
            }
            throw new NoItemFoundException("No Entities found in Paymentmethod");
        }

        public async Task<PaymentModel> GetByIdAsync(long Id)
        {
            var payment = await obj.PaymentRepository.GetByIdAsync(Id);
            if (payment is not null)
            {
                var mapped = mapper.Map<PaymentModel>(payment);
                return mapped;
            }
            throw new MarketException("No payment method exist");
        }

        public async Task RemovePayMentMethodAsync(long a)
        {
            await obj.PaymentMethodRepository.DeleteByIdAsync(a);
        }

        public async Task UpdateAsync(PaymentModel item)
        {
            ArgumentNullException.ThrowIfNull(item, nameof(item));
            if (item.Amount < 0) throw new ArgumentNullException(nameof(item.Amount));
            var method = await obj.PaymentMethodRepository.GetByIdAsync(item.paymentMethodId);
            if (method is null)
            {
                throw new NoItemFoundException("No related Items found");
            }
            var mapped = mapper.Map<Payment>(item);
            if (mapped is not null)
            {
                 obj.PaymentRepository.Update(mapped);
            }
            await obj.SaveAsync();
            throw new ArgumentException("Mapping not was succesfully");
        }

        public async Task UpdatePaymentMethodAsync(PaymentMethodModel mod)
        {

            ArgumentNullException.ThrowIfNull(mod, nameof(mod));
            if (mod.ExpiryDate > DateTime.Now) throw new ArgumentNullException(nameof(mod.ExpiryDate));
            var customer = await obj.CustomerRepository.GetByIdAsync(mod.CustomerId);
            if (customer is null)
            {
                throw new ArgumentNullException("Custumer is Null");
            }
            var mapped = mapper.Map<PaymentMethod>(mod);
            if (mapped is not null)
            {
                 obj.PaymentMethodRepository.Update(mapped);
            }
            await obj.SaveAsync();
            throw new ArgumentException("Mapping not was succesfully");
        }
    }
}
