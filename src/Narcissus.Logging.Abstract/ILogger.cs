using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Narcissus.Logging.Abstract
{
    public interface ILogger : IDisposable
    {
        Task LogAsync<TState>(LogLevel type, ILogContext LogContext, Exception ex, string message, TState state, CancellationToken token = default(CancellationToken)) where TState : class;
    }
}
