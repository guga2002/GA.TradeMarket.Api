using Microsoft.Extensions.Logging;

namespace GA.TradeMarket.Domain.Entitites
{
    public class AuditLog:AbstractEntity
    {
        public string LoggMesagge { get; set; }

        public DateTime date { get; set; }

        public string category { get; set; }

        public LogLevel level { get; set; }
    }
}
