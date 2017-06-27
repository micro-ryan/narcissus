using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Narcissus.Logging.Abstract
{
    public enum LogLevel
    {
        Fatal = 7,
        Critical = 6,
        Error = 5,
        Warn = 4,
        Info = 3,
        Debug = 2,
        Trace = 1,
        None = 0
    }
}
