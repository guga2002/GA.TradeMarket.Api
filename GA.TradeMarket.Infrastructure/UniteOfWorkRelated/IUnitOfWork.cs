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

        IReceiptDetailRepository ReceiptDetailRepository { get; }

        Task SaveAsync();
    }

}
