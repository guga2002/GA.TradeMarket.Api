using System.Runtime.Serialization;

namespace GA.TradeMarket.Application.Validation
{
    public class NoUserExistException : Exception
    {
        public NoUserExistException()
        {
        }

        public NoUserExistException(string? message) : base(message)
        {
        }

        public NoUserExistException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected NoUserExistException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
