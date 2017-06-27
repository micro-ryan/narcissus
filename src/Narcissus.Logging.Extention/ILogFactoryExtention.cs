using Narcissus.Logging.Abstract;
using Narcissus.Logging.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Narcissus.Logging.Extention
{
    public static class ILogFactoryExtention
    {
        public static ILogger CreateLogger<T>(this ILoggerFactory factory)
        {
            if (factory == null)
            {
                throw new ArgumentNullException(nameof(factory));
            }
            return factory.CreateLogger(typeof(T).FullName);
        }
    }
}
