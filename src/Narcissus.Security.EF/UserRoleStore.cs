using Narcissus.Security.Abstract.Store;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Narcissus.Security.EF
{
    public class UserRoleStore<TUser, TRole> : IUserRoleStore<TUser, TRole>
        where TUser : class
        where TRole : class
    {
        public Task<bool> AddUsersToRoles(IEnumerable<TUser> user, IEnumerable<TRole> role)
        {
            throw new NotImplementedException();
        }

        public Task<bool> AddUserToRole(TUser user, TRole role)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TRole>> FindRolesByUser(TUser user)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TUser>> FindUsersByRole(TRole role)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemoveUserFromRole(TUser user, TRole role)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemoveUsersFromRoles(IEnumerable<TUser> user, IEnumerable<TRole> role)
        {
            throw new NotImplementedException();
        }
    }
}
