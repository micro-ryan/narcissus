using System;
using System.Collections.Generic;
using System.Text;

namespace Narcissus.Security.Abstract.Options
{
    public class PasswordOptions
    {
        public int RequiredLength { get; set; } = 8;
        public int RequiredUniqueChars { get; set; } = 4;
        public bool RequireNonAlphanumeric { get; set; } = true;
        public bool RequireLowercase { get; set; } = true;
        public bool RequireUppercase { get; set; } = true;
        public bool RequireDigit { get; set; } = true;
    }
}
