using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace GA.TradeMarket.Application.Validation
{
    public class MarketException : Exception
    {
        public MarketException()
        {
        }

        public MarketException(string? message) : base(message)
        {
        }

        public MarketException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected MarketException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
