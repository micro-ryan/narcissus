using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Narcissus.Security.Abstract.Factories
{
    public class UserClaimsPrincipalFactory<TUser> : IUserClaimsPrincipalFactory<TUser> where TUser:class
    {
        public async Task<ClaimsPrincipal> CreateAsync(TUser user)
        {
            if (user == null)
                throw new ArgumentNullException(nameof(user));
            var id = await GenerateIdentityAsync(user);
            return new ClaimsPrincipal(id);
        }

        protected virtual async Task<ClaimsIdentity> GenerateIdentityAsync(TUser user)
        {
            throw new Exception();
        }
    }
}
