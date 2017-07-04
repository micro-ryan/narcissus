using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;

namespace Narcissus.Security.Core
{
    public class IdentityRoleClaim<TRoleKey, TClaimKey> where TRoleKey : IEquatable<TRoleKey>
    {
        public virtual TRoleKey RoleID { get; set; }
        public virtual TClaimKey ClaimID { get; set; }
    }
}
