using GA.TradeMarket.Domain.Data;
using GA.TradeMarket.Domain.Entitites;
using Microsoft.Extensions.Logging;

namespace GA.TradeMarket.Persistance.LogRelate
{
    public class Logger : ILogger
    {
        private readonly string _categoryName;
        private readonly Func<string, LogLevel, bool> _filter;
        private readonly TradeMarketDbContext _dbContext;

        public Logger(string categoryName, Func<string, LogLevel, bool> filter, TradeMarketDbContext dbContext)
        {
            _categoryName = categoryName;
            _filter = filter;
            _dbContext = dbContext;
        }

        public IDisposable BeginScope<TState>(TState state) => null;

        public bool IsEnabled(LogLevel logLevel) => _filter(_categoryName, logLevel);

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
        {
            if (!IsEnabled(logLevel))
            {
                return;
            }

            _dbContext.AuditLogs.Add(new AuditLog
            {
                level = logLevel,
                category = _categoryName,
                LoggMesagge = formatter(state, exception),
                date = DateTime.Now
            });

            _dbContext.SaveChanges(); 
        }
    }
}
