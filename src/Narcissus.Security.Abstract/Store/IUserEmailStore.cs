using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Narcissus.Security.Abstract
{
    public interface IUserEmailStore<TUser>:IDisposable 
        where TUser:class
    {
        Task<bool> SetEmailAsync(TUser user, string email, CancellationToken cancellationToken=default(CancellationToken));
        Task<string> GetEmailAsync(TUser user, CancellationToken cancellationToken = default(CancellationToken));
        Task<bool> GetEmailConfirmedAsync(TUser user, CancellationToken cancellationToken = default(CancellationToken));
        Task<bool> SetEmailConfirmedAsync(TUser user, bool confirmed, CancellationToken cancellationToken = default(CancellationToken));
        Task<TUser> FindByEmailAsync(string normalizedEmail, CancellationToken cancellationToken = default(CancellationToken));
    }
}
