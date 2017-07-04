using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Narcissus.Security.Abstract.Store
{
    public interface IUserLockOutStore<TUser> : IUserStore<TUser> where TUser : class
    {
        Task<DateTimeOffset?> GetLockoutEndDateAsync(TUser user, CancellationToken cancellationToken);
        Task SetLockoutEndDateAsync(TUser user, DateTimeOffset? lockoutEnd, CancellationToken cancellationToken);

        Task<int> GetAccessFailedCountAsync(TUser user, CancellationToken cancellationToken);
        Task<int> IncrementAccessFailedCountAsync(TUser user, CancellationToken cancellationToken);
        Task ResetAccessFailedCountAsync(TUser user, CancellationToken cancellationToken);
                
        Task<bool> GetLockoutEnabledAsync(TUser user, CancellationToken cancellationToken);
        Task SetLockoutEnabledAsync(TUser user, bool enabled, CancellationToken cancellationToken);
    }
}
