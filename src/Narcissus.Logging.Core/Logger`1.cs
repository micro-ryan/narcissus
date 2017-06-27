using Narcissus.Logging.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Narcissus.Logging.Core
{
    public class Logger<T> : ILogger<T>
    {
        private readonly ILogger _logger;
        public Logger(ILoggerFactory factory)
        {
            if (factory == null)
            {
                throw new ArgumentNullException(nameof(factory));
            }
            _logger = factory.CreateLogger(typeof(T).FullName);
        }

        public async Task LogAsync<TState>(LogLevel type, ILogContext LogContext, Exception ex, string message, TState state, CancellationToken token = default(CancellationToken)) where TState : class
        {
            await _logger.LogAsync<TState>(type, LogContext, ex, message, state);
        }

        public void Dispose()
        {
            if (_logger != null)
            {
                _logger.Dispose();
            }
        }
    }
}
