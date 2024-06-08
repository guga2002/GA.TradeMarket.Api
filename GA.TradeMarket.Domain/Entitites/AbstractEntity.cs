using System.ComponentModel.DataAnnotations;

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
