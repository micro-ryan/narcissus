﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Narcissus.Logging.Abstract
{
    public interface IServerEnvVariables
    {
        string AppPhysicalDir { get;  }
        string ServerIP { get;  }
        string ServerName { get; }
        string ServerOS { get; }
    }
}
