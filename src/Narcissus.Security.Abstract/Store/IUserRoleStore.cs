using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Narcissus.Security.Abstract.Store
{
    public interface IUserRoleStore<TUser, TRole>
        where TUser : class
        where TRole : class
    {
        Task<int> AddUserToRole(TUser user, TRole role, bool ThrowIfInRole=false);
        Task<int> RemoveUserFromRole(TUser user, TRole role, bool ThrowIfNotInRole = false);
        //batch operation
        Task<int> AddUsersToRoles(IEnumerable<TUser> users, IEnumerable<TRole> roles, bool ThrowIf, bool ThrowIfInRole = false);
        Task<int> RemoveUsersFromRoles(IEnumerable<TUser> users, IEnumerable<TRole> roles, bool ThrowIfNotInRole = false);

        Task<IEnumerable<TRole>> FindRolesByUser(TUser user);
        Task<IEnumerable<TUser>> FindUsersByRole(TRole role);
    }
}
