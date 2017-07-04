using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Narcissus.Security.Abstract.Options
{
    public class PasswordHasherOptions
    {
        private static readonly RandomNumberGenerator _defaultRng = RandomNumberGenerator.Create();

    }
}
