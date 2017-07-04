using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Narcissus.Security.Abstract.Store
{
    public interface IRoleClaimStore<TRole>:IRoleStore<TRole> 
        where TRole:class
    {
        Task AddClaimsAsync(IEnumerable<TRole> roles, IEnumerable<Claim> claims, CancellationToken cancellationToken = default(CancellationToken));
        Task RemoveClaimsAsync(IEnumerable<TRole> roles, IEnumerable<Claim> claims, CancellationToken cancellationToken = default(CancellationToken));
        Task<IList<Claim>> GetClaimsAsync(TRole role, CancellationToken cancellationToken = default(CancellationToken));
    }
}
