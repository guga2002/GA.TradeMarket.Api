using GA.TradeMarket.Application.Models;

namespace GA.TradeMarket.Application.Interfaces
{
    public interface IShippingService:Icrud<ShippingModel>
    {
        Task UpdateNotificationAsync(NotificationModel mod);
        Task RemoveNotificationAsync(long a);
        Task AddNotificationAsync(NotificationModel mod);
        Task<IEnumerable<NotificationModel>> GetAllNotificationAsync();
    }
}
