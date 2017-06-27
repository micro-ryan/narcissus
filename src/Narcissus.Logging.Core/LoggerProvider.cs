using Narcissus.Logging.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Narcissus.Logging.Core
{
    public abstract class LoggerProvider : ILoggerProvider
    {
        public LoggerProvider()
        {
        }

        public abstract ILogger Create(string catalog);

        public abstract void Dispose();
    }
}
