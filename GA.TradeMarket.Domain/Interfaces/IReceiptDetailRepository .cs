﻿using GA.TradeMarket.Domain.Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA.TradeMarket.Domain.Interfaces
{
    public interface IReceiptDetailRepository : ICrudRep<ReceiptDetail>
    {
        Task Delete(ReceiptDetail receiptDetail);
    }

}
