using System;
using System.Collections.Generic;
using System.Text;

namespace Narcissus.Security.Abstract
{
    public class SignInOptions
    {
        public bool RequireConfirmedEmail { get; set; } = false;
        public bool RequireConfirmedPhoneNumber { get; set; } = false;
    }
}
