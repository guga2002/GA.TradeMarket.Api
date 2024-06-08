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
    public class ReceiptService :AbstractService, IReceiptService
    {
        private readonly UserManager<Person> userManager;
        public ReceiptService(IUnitOfWork obj, IMapper mapper, UserManager<Person> userManager) :base(obj,mapper)
        {
            this.userManager = userManager;
        }

        public async Task AddAsync(ReceiptModelIn item)
        {
            if (item != null)
            {
                var customer= await obj.CustomerRepository.GetByIdAsync(item.CustomerId);
                if(customer is null)
                {
                    throw new ArgumentNullException(ErrorKeys.NoCustommer);
                }
                var mapped = mapper.Map<Receipt>(item);
                if (mapped != null)
                {
                    await obj.ReceiptRepository.AddAsync(mapped);
                    await obj.SaveAsync();
                }
                else
                {
                    throw new MarketException(ErrorKeys.General);
                }
            }
            else
            {
                throw new MarketException(ErrorKeys.General);
            }
        }

        public async Task AddProductAsync(long productId, long receiptId, int quantity)
        {
            var receipt = await obj.ReceiptRepository.GetByIdWithDetailsAsync(receiptId);
            if (receipt == null)
            {
                throw new MarketException(ErrorKeys.NotFound);
            }

            if (obj.ProductRepository != null)
            {
                var product = await obj.ProductRepository.GetByIdAsync(productId);

                if (product == null)
                {
                    throw new MarketException(ErrorKeys.NoProduct);
                }
                ReceiptDetail details = new ReceiptDetail()
                {
                    ProductId = product.Id,
                    ReceiptId = receipt.Id,
                    UnitPrice = product.Price,
                   Quantity=quantity,
                   DiscountUnitPrice=receipt.order.Customer.DiscountValue
                };
                await obj.ReceiptDetailRepository.AddAsync(details);
                await obj.SaveAsync();
            }
            else
            {
                if (receipt.ReceiptDetails != null)
                {
                    foreach (var item in receipt.ReceiptDetails)
                    {
                        item.Quantity += quantity;
                    }
                    await obj.SaveAsync();
                }
            }

        }

        public async Task CheckOutAsync(long id)
        {
            var res = await obj.ReceiptRepository.GetByIdAsync(id);
            res.IsCheckedOut = true;
            await obj.SaveAsync();
        }


        public async Task DeleteAsync(long item)
        {
            await obj.SaveAsync();
            var receipt = await obj.ReceiptRepository.GetByIdWithDetailsAsync(item);
            var res = receipt.ReceiptDetails;
            await obj.ReceiptRepository.DeleteByIdAsync(receipt.Id);
            if (res is not null)
            {
                foreach (var ite in res)
                {
                   await obj.ReceiptDetailRepository.Delete(ite);
                }
            }
        }

        public async Task<IEnumerable<ReceiptModel>> GetAllReceiptsForCurrentUser(string userName)
        {
           var user= await userManager.FindByNameAsync(userName);
            if(user is not null)
            {
                var res=await obj.ReceiptRepository.GetAllWithDetailsAsync();
                var receipts= res.Where(io=>io.order.CustomerId==user.Customer.Id).ToList();
                var mapped=mapper.Map<IEnumerable<ReceiptModel>>(receipts);
                return mapped;
            }
            throw new UnauthorizedAccessException(ErrorKeys.NoCustommer);
        }

        public async Task<IEnumerable<ReceiptModel>> GetAllWithDetailsAsync()
        {
            var res = await obj.ReceiptRepository.GetAllWithDetailsAsync();
            if (res == null) throw new MarketException(ErrorKeys.General);
            var mapped = mapper.Map<IEnumerable<ReceiptModel>>(res);
            if (mapped != null)
            {
                return mapped;
            }
            else
            {
                throw new MarketException(ErrorKeys.General);
            }
        }

        public async Task<ReceiptModel> GetByIdAsync(long Id)
        {
            var res = await obj.ReceiptRepository.GetByIdAsync(Id);
            if (res != null)
            {
                var mapped = mapper.Map<ReceiptModel>(res);

                return mapped;
            }
            else
            {
                throw new MarketException(ErrorKeys.NotFound);
            }

        }

        public async Task<IEnumerable<ReceiptDetailModel>> GetReceiptDetailsAsync(long id)
        {
            var res = await obj.ReceiptRepository.GetByIdWithDetailsAsync(id);
            var details = res.ReceiptDetails;

            var mapped = mapper.Map<IEnumerable<ReceiptDetailModel>>(details);

            return mapped;

        }

        public async Task<IEnumerable<ReceiptModel>> GetReceiptsByPeriodAsync(DateTime start, DateTime end)
        {
            var rec = await obj.ReceiptRepository.GetAllWithDetailsAsync();
            var sab = rec.Where(io => io.order.OrderDate >= start && io.order.OrderDate <= end).ToList();
            List<ReceiptModel> Receipts = new List<ReceiptModel>();
            foreach (var item in sab)
            {
                if (item.ReceiptDetails != null)
                {
                    ReceiptModel mod = new ReceiptModel()
                    {
                        IsCheckedOut = item.IsCheckedOut,

                        CustomerId = item.order.CustomerId,
                        Id = item.Id,
                    };
                    Receipts.Add(mod);
                }
            }
            return Receipts;
        }

        public async Task<decimal> GetReceiptSum(long id)
        {
            var res = await obj.ReceiptDetailRepository.GetByIdAsync(id);

            if (res != null)
            {
                return res.Quantity * res.UnitPrice;
            }
            return 0;
        }

        public async Task RemoveProductAsync(long productId, long id, int quantity)
        {
            var res = await obj.ReceiptRepository.GetByIdWithDetailsAsync(id);
            if (res != null && res.ReceiptDetails != null)
            {

                var detail = res.ReceiptDetails.First(rd => rd.ProductId == productId);
                if (detail != null)
                {
                    if (detail.Quantity <= 0 || detail.ReceiptId == id && detail.ProductId == 1)
                    {

                        if (obj.ReceiptDetailRepository != null)
                        {
                            await obj.ReceiptDetailRepository.Delete(detail);
                            await obj.SaveAsync();
                        }
                        else
                        {
                            detail.Quantity -= quantity;
                            await obj.SaveAsync();
                        }
                    }
                    else
                    {
                        detail.Quantity -= quantity;
                        await obj.SaveAsync();
                    }
                }
            }
        }

        public async Task<decimal> ToPayAsync(long id)
        {

            decimal shedeg = 0;
            var res = await obj.ReceiptRepository.GetByIdWithDetailsAsync(id);
            if (res.ReceiptDetails != null)
            {
                var rec = res.ReceiptDetails.ToList();
                foreach (var item in rec)
                {
                    decimal temp = 0;
                    temp += item.DiscountUnitPrice * item.Quantity;
                    shedeg += temp;
                }
                return shedeg;
            }
            return 0;
        }

        public async Task UpdateAsync(ReceiptModelIn item)
        {
            if (item == null)
            {
                throw new MarketException(ErrorKeys.General);
            }
            var customer= await obj.CustomerRepository.GetByIdAsync(item.CustomerId);
            if(customer == null)
            {
                throw new ArgumentNullException(ErrorKeys.General);
            }
            var mapped = mapper.Map<Receipt>(item);
            obj.ReceiptRepository.Update(mapped);
            await obj.SaveAsync();
        }
    }

}
