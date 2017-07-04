using System;
using System.Collections.Generic;
using System.Text;

namespace Narcissus.Security.Abstract
{
    public class LockOutOptions
    {
        public int MaxFailedAccessAttempts { get; set; } = 5;
        public TimeSpan DefaultLockoutTimeSpan { get; set; } = TimeSpan.FromDays(1);
    }
}
