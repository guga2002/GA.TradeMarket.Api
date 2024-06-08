using GA.TradeMarket.Application.Models;
using GA.TradeMarket.Application.Models.RequestModels;

namespace GA.TradeMarket.Application.Interfaces
{
    public interface IShippingService:Icrud<ShippingModel,ShippingModelIn>
    {
        Task UpdateNotificationAsync(NotificationModelIn mod);
        Task RemoveNotificationAsync(long a);
        Task AddNotificationAsync(NotificationModelIn mod);
        Task<IEnumerable<NotificationModel>> GetAllNotificationAsync();
        Task<bool> UpdateShippingStatus(ShippingStatusUpdateModel update);
        Task SendNotificationstoUsers();
        Task<IEnumerable<NotificationModel>> GetAllUnsentNotifications();
    }
}
