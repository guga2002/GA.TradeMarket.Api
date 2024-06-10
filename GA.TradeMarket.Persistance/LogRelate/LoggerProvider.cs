using GA.TradeMarket.Domain.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace GA.TradeMarket.Persistance.LogRelate
{
    public class LoggerProvider : ILoggerProvider
    {
        private readonly Func<string, LogLevel, bool> _filter;
        private readonly TradeMarketDbContext _dbContext;

        public LoggerProvider(Func<string, LogLevel, bool> filter, TradeMarketDbContext dbContext)
        {
            _filter = filter;
            _dbContext = dbContext;
        }

        public ILogger CreateLogger(string categoryName)
        {
            return new Logger(categoryName, _filter, _dbContext);
        }

        public void Dispose() { }
    }
}
