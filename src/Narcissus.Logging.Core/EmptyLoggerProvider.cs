using Narcissus.Logging.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Narcissus.Logging.Core
{
    public class EmptyLoggerProvider : ILoggerProvider
    {
        public string ProviderName
        {
            get
            {
                return nameof(EmptyLoggerProvider);
            }
        }

        public ILogger Create(string catalog)
        {
            return new EmptyLogger();
        }

        public void Dispose()
        {
           
        }
    }
}
