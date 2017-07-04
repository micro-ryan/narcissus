using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Narcissus.Security.Abstract.Store
{
    public interface IUserSecurityStampStore<TUser> where TUser : class
    {
        Task<int> SetSecurityStampAsync(TUser user, string stamp, CancellationToken cancellationToken);
        Task<string> GetSecurityStampAsync(TUser user, CancellationToken cancellationToken);
    }
}
