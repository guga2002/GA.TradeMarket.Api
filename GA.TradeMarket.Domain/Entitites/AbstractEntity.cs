using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA.TradeMarket.Domain.Entitites
{
    public abstract class AbstractEntity
    {
        [Key]
        public long Id { get; set; }

        protected AbstractEntity()
        {

        }
        protected AbstractEntity(int id)
        {
            Id = id;
        }
    }

}
