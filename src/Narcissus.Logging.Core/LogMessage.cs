using Narcissus.Logging.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Narcissus.Logging.Core
{
    public class LogMessage<T>
    {
        public LogMessage()
        {
        }

        public T State { get; set; }
        public ILogContext LogContext { get; set; }
        public LogLevel Level { get; set; }
        public Exception Error { get; set; }
        public string Message { get; set; }
        public string StackTrace { get; set; }
    }
}
