using GA.TradeMarket.Domain.Data;
using GA.TradeMarket.Domain.Interfaces;
using GA.TradeMarket.Infrastructure.Repositories;

namespace GA.TradeMarket.Infrastructure.UniteOfWorkRelated
{
    public class UniteOfWork:IUnitOfWork
    {
        public UniteOfWork(TradeMarketDbContext db,
     ICustomerRepository customerRepository,
     IProductRepository productRepository,
     IProductCategoryRepository productCategoryRepository,
     IReceiptRepository receiptRepository,
     IReceiptDetailRepository receiptDetailRepository)
        {
            CustomerRepository = customerRepository;
            ProductRepository = productRepository;
            ProductCategoryRepository = productCategoryRepository;
            ReceiptRepository = receiptRepository;
            this.ReceiptDetailRepository = receiptDetailRepository;
            _dbContext = db;
        }
        private readonly TradeMarketDbContext _dbContext;
        public ICustomerRepository CustomerRepository { get; }
        public IProductRepository ProductRepository { get; }
        public IProductCategoryRepository ProductCategoryRepository { get; }
        public IReceiptRepository ReceiptRepository { get; }
        public IReceiptDetailRepository ReceiptDetailRepository { get; }

        public IBonusProgramRepository bonusProgramRepository => new BonusRepository(_dbContext);

        public ICouponRepository CouponRepository => new CouponRepository(_dbContext);

        public INotificationRepository NotificationRepository => new NotificationRepository(_dbContext);

        public IOrderRepository OrderRepository => new OrderRepository(_dbContext);

        public IPaymentMethodRepository PaymentMethodRepository => new PaymentMethodRepository(_dbContext);

        public IPaymentRepository PaymentRepository => new PaymentRepository(_dbContext);

        public IReturnRequestRepository ReturnRequestRepository => new ReturnRequestRepository(_dbContext);

        public IReviewRepository reviewRepository => new ReviewRepository(_dbContext);

        public IShipingRepository ShipingRepository => new ShipingRepository(_dbContext);

        public async Task SaveAsync()
        {
            await _dbContext.SaveChangesAsync();
        }

    }
}
