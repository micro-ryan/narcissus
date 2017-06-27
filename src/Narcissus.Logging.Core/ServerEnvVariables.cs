using Narcissus.Logging.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Narcissus.Logging.Core
{
    public sealed class ServerEnvVariables : IServerEnvVariables
    {
        private readonly string _AppPhysicalDir;
        private readonly string _ServerIP;
        private readonly string _ServerName;
        private readonly string _ServerOS;
        private static volatile ServerEnvVariables instance;
        private static object syncRoot = new Object();

        private ServerEnvVariables()
        {
            _AppPhysicalDir = "";
            _ServerIP = "";
            _ServerName = "";
            _ServerOS = "";
        }
        public static ServerEnvVariables Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new ServerEnvVariables();
                    }
                }

                return instance;
            }
        }

        public string AppPhysicalDir
        {
            get
            {
                return _AppPhysicalDir;
            }
        }

        public string ServerIP
        {
            get
            {
                return _ServerIP;
            }
        }

        public string ServerName
        {
            get
            {
                return _ServerName;
            }
        }

        public string ServerOS
        {
            get
            {
                return _ServerOS;
            }
        }
    }
}
