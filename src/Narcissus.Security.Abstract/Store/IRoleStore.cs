using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Narcissus.Security.Abstract.Store
{
    public interface IRoleStore<TRole> : IDisposable 
        where TRole : class
    {
        Task<bool> CreateAsync(TRole role, CancellationToken cancellationToken);
        Task<bool> UpdateAsync(TRole role, CancellationToken cancellationToken);
        Task<bool> DeleteAsync(TRole role, CancellationToken cancellationToken);
        Task<bool> DeactiveAsync(TRole role, CancellationToken cancellationToken);
        Task<IEnumerable<TRole>> GetRolesAsync(CancellationToken cancellationToken);
    }
}
