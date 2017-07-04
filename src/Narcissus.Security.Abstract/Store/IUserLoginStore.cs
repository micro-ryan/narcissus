using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Narcissus.Security.Abstract.Store
{
    public interface IUserLoginStore<TUser> where TUser : class
    {
        Task AddLoginAsync(TUser user, UserLoginInfo login, CancellationToken cancellationToken);
        Task RemoveLoginAsync(TUser user, string loginProvider, string providerKey, CancellationToken cancellationToken);
        Task<IList<UserLoginInfo>> GetLoginsAsync(TUser user, CancellationToken cancellationToken);
        Task<TUser> FindByLoginAsync(string loginProvider, string providerKey, CancellationToken cancellationToken);
    }
}
