using Narcissus.Logging.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Narcissus.Logging.Core
{
    public class EmptyLogger : ILogger
    {
        public void Dispose()
        {

        }

        public Task LogAsync<TState>(LogLevel type, ILogContext LogContext, Exception ex, string message, TState state, CancellationToken token = default(CancellationToken)) where TState : class
        {
            return Task.CompletedTask;
        }
    }
}
