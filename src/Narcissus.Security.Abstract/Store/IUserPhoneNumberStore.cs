using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Narcissus.Security.Abstract
{
    public interface IUserPhoneNumberStore<TUser> :IDisposable 
        where TUser:class
    {
        Task<bool> SetPhoneNumberAsync(TUser user, string phoneNumber, CancellationToken cancellationToken = default(CancellationToken));
        Task<bool> GetPhoneNumberAsync(TUser user, CancellationToken cancellationToken = default(CancellationToken));
        Task<bool> GetPhoneNumberConfirmedAsync(TUser user, CancellationToken cancellationToken = default(CancellationToken));
        Task<bool> SetPhoneNumberConfirmedAsync(TUser user, bool confirmed, CancellationToken cancellationToken = default(CancellationToken));
        Task<TUser> FindByPhoneNumberAsync(string normalizedEmail, CancellationToken cancellationToken = default(CancellationToken));
    }
}
