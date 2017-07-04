using System;
using System.Collections.Generic;
using System.Text;

namespace Narcissus.Security.Core
{
    public class IdentityUser<TUserKey> where TUserKey : IEquatable<TUserKey>
    {
        public virtual TUserKey ID { get; set; }
        public virtual string UserName { get; set; }
        public virtual string Email { get; set; }
        public virtual string NormalizedEmail { get; set; }
        public virtual bool? EmailConfirmed { get; set; }
        public virtual string PhoneNumber { get; set; }
        public virtual string NormalizedPhoneNumber { get; set; }
        public virtual bool? PhoneNumberConfirmed { get; set; }
        public virtual DateTimeOffset? LockoutEnd { get; set; }
        public virtual int? AccessFailedCount { get; set; }
        public virtual bool IsActive { get; set; }
        public virtual DateTimeOffset? DeactivedSince { get; set; }
    }
}
