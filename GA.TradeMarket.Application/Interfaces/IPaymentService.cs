using GA.TradeMarket.Application.Models;
using GA.TradeMarket.Application.Models.RequestModels;

namespace GA.TradeMarket.Application.Interfaces
{
    public interface IPaymentService:Icrud<PaymentModel,PaymentModelIn>
    {
        Task UpdatePaymentMethodAsync(PaymentMethodModelIn mod);
        Task RemovePayMentMethodAsync(long a);
        Task AddPaymentMethodAsync(PaymentMethodModelIn mod);
        Task<IEnumerable<PaymentMethodModel>> GetAllPaymentMethodAsync();

        Task<IEnumerable<PaymentMethodModel>> GetallPaymentMethodForCurrentUser(string userName);
        Task<IEnumerable<PaymentModel>> GetallPaymentForCurrentUser(string userName);
    }
}
