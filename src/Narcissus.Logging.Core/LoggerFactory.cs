using Narcissus.Logging.Abstract;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Narcissus.Logging.Core
{
    public class LoggerFactory : ILoggerFactory
    {
        private readonly ConcurrentDictionary<string, ILoggerProvider> _providers = new ConcurrentDictionary<string, ILoggerProvider>();        
        private volatile bool _disposed;

        public LoggerFactory() : this(Enumerable.Empty<ILoggerProvider>())
        {
        }

        public LoggerFactory(IEnumerable<ILoggerProvider> providers)
        {
            if (providers == null)
                providers = Enumerable.Empty<ILoggerProvider>();
            foreach (var provider in providers.ToList())
            {
                _providers.TryAdd(provider.GetType().FullName, provider);
            }
        }
        public bool TryAddProvider(ILoggerProvider provider)
        {
            return _providers.TryAdd(provider.GetType().FullName, provider);
        }
        public ILogger CreateLogger(string catalogName)
        {
            var loggers = CreateLoggers(catalogName);
            return new Logger(loggers);
        }

        public void Dispose()
        {
            if (_disposed == true)
                return;
            _disposed = true;
            foreach (var provider in _providers)
            {
                provider.Value?.Dispose();
            }
        }

        private IEnumerable<ILogger> CreateLoggers(string catalogName)
        {
            var registerLoggers = new List<ILogger>();
            foreach (var provider in _providers)
            {
                registerLoggers.Add(provider.Value.Create(catalogName));
            }
            return registerLoggers;
        }
    }
}
