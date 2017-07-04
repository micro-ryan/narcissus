using System;
using System.Collections.Generic;
using System.Text;

namespace Narcissus.Security.Core
{
    public class IdentityUserRole<TUserKey, TRoleKey>
        where TUserKey : IEquatable<TUserKey>
        where TRoleKey : IEquatable<TRoleKey>
    {
        public virtual TUserKey UserID { get; set; }
        public virtual TRoleKey RoleID { get; set; }
    }
}
