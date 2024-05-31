using GA.TradeMarket.Domain.Data;
using GA.TradeMarket.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public async Task SaveAsync()
        {
            await _dbContext.SaveChangesAsync();
        }

    }
}
