using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Narcissus.Security.Core
{
    public class PasswordHasherOptions
    {
        private static readonly RandomNumberGenerator _defaultRng = RandomNumberGenerator.Create(); // secure PRNG
        public int IterationCount { get; set; } = 10000;
        internal RandomNumberGenerator Rng { get; set; } = _defaultRng;
    }
}
