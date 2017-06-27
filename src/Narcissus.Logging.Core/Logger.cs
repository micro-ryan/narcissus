using Narcissus.Logging.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Narcissus.Logging.Core
{
    public class Logger : ILogger
    {
        private readonly IEnumerable<ILogger> _loggers;
        public Logger(IEnumerable<ILogger> loggers)
        {
            if (loggers == null)
                loggers = Enumerable.Empty<ILogger>();
            _loggers = loggers;
        }

        public async Task LogAsync<TState>(LogLevel type, ILogContext LogContext, Exception ex, string message, TState state, CancellationToken token = default(CancellationToken)) where TState : class
        {
            if (_loggers == null)
                return;
            foreach (var logger in _loggers)
            {
                await logger.LogAsync<TState>(type, LogContext, ex, message, state);
            }
        }

        public void Dispose()
        {
            if (_loggers != null)
            {
                foreach (var logger in _loggers)
                {
                    logger.Dispose();
                }
            }
        }
    }
}
