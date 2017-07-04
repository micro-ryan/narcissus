using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Narcissus.Security.Abstract.Factories
{
    public interface IUserClaimsPrincipalFactory<TUser> where TUser:class
    {
        Task<ClaimsPrincipal> CreateAsync(TUser user);
    }
}
