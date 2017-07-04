using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;

namespace Narcissus.Security.Core
{
    public class IdentityClaims<TClaimKey> where TClaimKey : IEquatable<TClaimKey>
    {
        public virtual TClaimKey ID { get; set; }
        public virtual Claim Claim { get; set; }
    }
}
