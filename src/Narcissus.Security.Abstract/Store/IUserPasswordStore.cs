using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Narcissus.Security.Abstract.Store
{
    public interface IUserPasswordStore<TUser> where TUser : class
    {
        Task SetPasswordHashAsync(TUser user, string passwordHash, CancellationToken cancellationToken);
        Task<string> GetPasswordHashAsync(TUser user, CancellationToken cancellationToken);
        Task<bool> HasPasswordAsync(TUser user, CancellationToken cancellationToken);
    }
}
