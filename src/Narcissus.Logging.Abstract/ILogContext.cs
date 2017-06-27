using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Narcissus.Logging.Abstract
{
    public interface ILogContext
    {
        string URI { get; set; }
        string Catalog { get; set; }
        string Operation { get; set; }
        string ProcessID { get; set; }
        string ThreadID { get; set; }
        IIdentity User { get; set; }
        IAppContext AppContext { get; }
    }
}
