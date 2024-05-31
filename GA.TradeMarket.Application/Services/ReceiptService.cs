﻿using AutoMapper;
using GA.TradeMarket.Application.Interfaces;
using GA.TradeMarket.Application.Models;
using GA.TradeMarket.Application.Validation;
using GA.TradeMarket.Domain.Entitites;
using GA.TradeMarket.Infrastructure.UniteOfWorkRelated;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA.TradeMarket.Application.Services
{
    public class ReceiptService :AbstractService, IReceiptService
    {

        public ReceiptService(IUnitOfWork obj, IMapper mapper):base(obj,mapper)
        {
        }

        public async Task AddAsync(ReceiptModel item)
        {
            if (item != null)
            {
                var mapped = mapper.Map<Receipt>(item);
                if (mapped != null)
                {
                    await obj.ReceiptRepository.AddAsync(mapped);
                    await obj.SaveAsync();
                }
                else
                {
                    throw new MarketException("kide");
                }
            }
            else
            {
                throw new MarketException("kide");
            }
        }

        public async Task AddProductAsync(long productId, long receiptId, int quantity)
        {
            var receipt = await obj.ReceiptRepository.GetByIdWithDetailsAsync(receiptId);
            if (receipt == null)
            {
                throw new MarketException($"Receipt with ID {receiptId} does not exist.");
            }

            if (obj.ProductRepository != null)
            {
                var product = await obj.ProductRepository.GetByIdAsync(productId);

                if (product == null)
                {
                    throw new MarketException("no product exist");
                }
                ReceiptDetail details = new ReceiptDetail()
                {
                    ProductId = product.Id,
                    ReceiptId = receipt.Id,
                    UnitPrice = product.Price,
                   Quantity=quantity,
                   DiscountUnitPrice=receipt.Customer.DiscountValue
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
                    obj.ReceiptDetailRepository.Delete(ite);
                }
            }
        }

        public async Task<IEnumerable<ReceiptModel>> GetAllAsync()
        {
            var res = await obj.ReceiptRepository.GetAllWithDetailsAsync();
            if (res == null) throw new MarketException("ahaa");
            var mapped = mapper.Map<IEnumerable<ReceiptModel>>(res);
            if (mapped != null)
            {
                return mapped;
            }
            else
            {
                throw new MarketException("gassworaa");
            }
        }

        public async Task<ReceiptModel> GetByIdAsync(long Id)
        {
            var res = await obj.ReceiptRepository.GetByIdWithDetailsAsync(Id);
            if (res != null)
            {
                var mapped = mapper.Map<ReceiptModel>(res);

                return mapped;
            }
            else
            {
                throw new MarketException("Exception");
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
            var sab = rec.Where(io => io.OperationDate >= start && io.OperationDate <= end).ToList();
            List<ReceiptModel> Receipts = new List<ReceiptModel>();
            foreach (var item in sab)
            {
                if (item.ReceiptDetails != null)
                {
                    ReceiptModel mod = new ReceiptModel()
                    {
                        IsCheckedOut = item.IsCheckedOut,
                        OperationDate = item.OperationDate,
                        CustomerId = item.CustomerId,
                        ReceiptDetailsIds = item.ReceiptDetails.Select(io => io.Id).ToList(),
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
                            obj.ReceiptDetailRepository.Delete(detail);
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

        public Task UpdateAsync(ReceiptModel item)
        {
            if (item == null)
            {
                throw new MarketException("Exception ocured");
            }
            var mapped = mapper.Map<Receipt>(item);
            obj.ReceiptRepository.Update(mapped);
            obj.SaveAsync();
            return Task.CompletedTask;
        }
    }

}