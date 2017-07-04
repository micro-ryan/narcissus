using System;
using System.Collections.Generic;
using System.Text;

namespace Narcissus.Security.Core
{
    public class IdentityUserClaim<TUserKey, TClaimKey> 
        where TUserKey : IEquatable<TUserKey>
        where TClaimKey : IEquatable<TClaimKey>
    {
        public virtual TUserKey UserID { get; set; }
        public virtual TClaimKey ClaimID { get; set; }
    }
}
