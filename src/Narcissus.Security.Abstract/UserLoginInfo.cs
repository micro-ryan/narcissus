using System;
using System.Collections.Generic;
using System.Text;

namespace Narcissus.Security.Abstract
{
    public class UserLoginInfo
    {
        public string LoginProvider { get; set; }
        public string ProviderKey { get; set; }
        public string ProviderDisplayName { get; set; }
    }
}
