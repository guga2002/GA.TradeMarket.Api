using GA.TradeMarket.Application.Models;

namespace GA.TradeMarket.Application.Interfaces
{
    public interface IPaymentService:Icrud<PaymentModel>
    {
        Task UpdatePaymentMethodAsync(PaymentMethodModel mod);
        Task RemovePayMentMethodAsync(long a);
        Task AddPaymentMethodAsync(PaymentMethodModel mod);
        Task<IEnumerable<PaymentMethodModel>> GetAllPaymentMethodAsync();
    }
}
