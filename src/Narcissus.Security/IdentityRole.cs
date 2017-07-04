using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;

namespace Narcissus.Security.Core
{
    public class IdentityRole<TRoleKey> where TRoleKey : IEquatable<TRoleKey>
    {
        public virtual TRoleKey ID { get; set; }
        public virtual string Name { get; set; }
        public virtual string NormalizedName { get; set; }        
    }
}
