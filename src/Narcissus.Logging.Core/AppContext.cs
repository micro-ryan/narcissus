using Narcissus.Logging.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Narcissus.Logging.Core
{
    public class AppContext : IAppContext
    {
        private readonly IServerEnvVariables _envVariables;
        public AppContext(IServerEnvVariables envVariables)
        {
            _envVariables = envVariables;
        }
        public IServerEnvVariables EnvVariables
        {
            get
            {
                return _envVariables;
            }
        }
    }
}
