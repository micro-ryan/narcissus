using System;
using System.Threading;
using System.Threading.Tasks;

namespace Narcissus.Security.Abstract
{
    public interface IUserStore<TUser> : IDisposable
        where TUser : class
    {
        Task<int> CreateAsync(TUser user, CancellationToken cancellationToken = default(CancellationToken));
        Task<int> UpdateAsync(TUser user, CancellationToken cancellationToken = default(CancellationToken));
        Task<int> DeleteAsync(TUser user, CancellationToken cancellationToken = default(CancellationToken));
        Task<int> DeactiveAsync(TUser user, CancellationToken cancellationToken = default(CancellationToken));
    }
}
