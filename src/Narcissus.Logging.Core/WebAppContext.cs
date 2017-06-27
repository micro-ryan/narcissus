using Narcissus.Logging.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Narcissus.Logging.Core
{
    public class WebAppContext : AppContext, IWebAppContext
    {
        private readonly string _appName;
        private readonly string _appVirtualDir;
        private readonly string _hostSoftware;
        public WebAppContext(IServerEnvVariables envVariables) : base(envVariables)
        {
            _appName = "";
            _appVirtualDir = "";
            _hostSoftware = "";
        }

        public string AppName
        {
            get
            {
                return _appName;
            }
        }

        public string AppVirtualDir
        {
            get
            {
                return _appVirtualDir;
            }
        }

        public string HostSoftware
        {
            get
            {
                return _hostSoftware;
            }
        }
    }
}
