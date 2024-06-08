using AutoMapper;
using GA.TradeMarket.Application.Interfaces;
using GA.TradeMarket.Application.Models;
using GA.TradeMarket.Application.Models.RequestModels;
using GA.TradeMarket.Application.StaticFIles;
using GA.TradeMarket.Application.Validation;
using GA.TradeMarket.Domain.Entitites;
using GA.TradeMarket.Infrastructure.UniteOfWorkRelated;
using Microsoft.AspNetCore.Identity;

namespace GA.TradeMarket.Application.Services
{
    public class PaymentService : AbstractService,IPaymentService
    {
        private readonly UserManager<Person> userManager;
        public PaymentService(IUnitOfWork obj, IMapper map, UserManager<Person> userManager) : base(obj, map)
        {
            this.userManager = userManager;
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

        public async Task<IEnumerable<PaymentMethodModel>> GetallPaymentMethodForCurrentUser(string userName)
        {
            var user= await userManager.FindByNameAsync(userName);
            if(user is null)
            {
                throw new MarketException(ErrorKeys.NoCustommer);
            }
            var paymemethods=await obj.PaymentRepository.GetAllWithDetailsAsync();
           var res= paymemethods.Where(io => io.Order.Customer.PersonId == user.Id).Select(io=>io.method);
            var mapped=mapper.Map<IEnumerable<PaymentMethodModel>>(res);
            return mapped;
        }

        public async Task<IEnumerable<PaymentModel>> GetallPaymentForCurrentUser(string userName)
        {
            var user = await userManager.FindByNameAsync(userName);
            if (user is null)
            {
                throw new MarketException(ErrorKeys.NoCustommer);
            }
            var payments = await obj.PaymentRepository.GetAllWithDetailsAsync();
            var filtered = payments.Where(io => io.Order.Customer.PersonId == user.Id).ToList();
            var mapped = mapper.Map<IEnumerable<PaymentModel>>(filtered);
            return mapped;
        }
    }
}
