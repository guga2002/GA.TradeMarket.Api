using AutoMapper;
using GA.TradeMarket.Infrastructure.UniteOfWorkRelated;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA.TradeMarket.Application.Services
{
    public abstract class AbstractService
    {
        protected  readonly IUnitOfWork obj;
        protected  readonly IMapper mapper;

        public AbstractService(IUnitOfWork obj, IMapper map)
        {
            this.obj = obj;
            this.mapper = map;

        }
    }
}
