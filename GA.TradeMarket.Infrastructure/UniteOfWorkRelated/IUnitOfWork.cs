using GA.TradeMarket.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA.TradeMarket.Infrastructure.UniteOfWorkRelated
{
    public interface IUnitOfWork
    {
        ICustomerRepository CustomerRepository { get; }

        IProductRepository ProductRepository { get; }

        IProductCategoryRepository ProductCategoryRepository { get; }

        IReceiptRepository ReceiptRepository { get; }

        IExchangeRateRepository ExchangeRateRepository { get; }

        IReceiptDetailRepository ReceiptDetailRepository { get; }

        IBonusProgramRepository bonusProgramRepository { get; }

        ICouponRepository CouponRepository { get; }

        INotificationRepository NotificationRepository { get; }

        IOrderRepository OrderRepository { get; }

        IPaymentMethodRepository PaymentMethodRepository { get; }

        IPaymentRepository PaymentRepository { get; }

        IReturnRequestRepository ReturnRequestRepository { get; }

        IReviewRepository reviewRepository { get; }

        IShipingRepository ShipingRepository { get; }
        Task SaveAsync();
    }

}
