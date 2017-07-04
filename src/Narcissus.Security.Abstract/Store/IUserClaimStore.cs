using System.Collections.Generic;
using System.Security.Claims;
using System.Threading;
using System.Threading.Tasks;

namespace Narcissus.Security.Abstract.Store
{
    public interface IUserClaimStore<TUser> where TUser:class
    {
        Task<IList<Claim>> GetClaimsAsync(TUser user, CancellationToken cancellationToken);
        Task AddClaimsAsync(TUser user, IEnumerable<Claim> claims, CancellationToken cancellationToken);
        Task RemoveClaimsAsync(TUser user, IEnumerable<Claim> claims, CancellationToken cancellationToken);
        Task ReplaceClaimAsync(TUser user, Claim claim, Claim newClaim, CancellationToken cancellationToken);
        Task<IList<TUser>> GetUsersForClaimAsync(Claim claim, CancellationToken cancellationToken);
    }
}
