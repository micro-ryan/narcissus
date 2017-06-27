using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Narcissus.Logging.Abstract
{
    public interface ILoggerProvider:IDisposable
    {
        ILogger Create(string catalog);
    }
}
