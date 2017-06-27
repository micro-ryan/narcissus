using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Narcissus.Logging.Core
{
    public class LoggerProviderComparer : IEqualityComparer<LoggerProvider>
    {
        public bool Equals(LoggerProvider x, LoggerProvider y)
        {
            if (x == null && y == null)
                return true;
            else if (x == null | y == null)
                return false;
            else if (string.Compare(x.GetType().FullName, y.GetType().FullName) == 0)
                return true;
            return false;
        }

        public int GetHashCode(LoggerProvider obj)
        {
            string hcode = obj.GetType().FullName;
            return hcode.GetHashCode();
        }
    }
}
