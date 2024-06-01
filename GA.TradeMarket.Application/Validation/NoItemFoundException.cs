using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace GA.TradeMarket.Application.Validation
{
    public class NoItemFoundException : Exception
    {
        public NoItemFoundException()
        {
        }

        public NoItemFoundException(string? message) : base(message)
        {
        }

        public NoItemFoundException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected NoItemFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
