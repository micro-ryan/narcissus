using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Narcissus.Security.Abstract
{
    public interface ISignInManager<TUser> where TUser:class
    {
        Task<ClaimsPrincipal> CreateUserPrincipalAsync(TUser user);
        Task<SignInResult> SignInAsync(TUser user, string password, bool isPersistent);
        Task SignOutAsync(TUser user);
        bool IsSignedIn(ClaimsPrincipal principal);
    }
}
