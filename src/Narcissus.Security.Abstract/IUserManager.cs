using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Narcissus.Security.Abstract
{
    public interface IUserManager<TUser>
    {
        Task<bool> CreateUser(TUser user);
        Task<bool> DeactiveUser(TUser user);
        Task<bool> DeleteUser(TUser user);
        Task<ClaimsPrincipal> SignIn(TUser user);
        Task<bool> SignOut(TUser user);
    }
}
