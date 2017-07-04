using Microsoft.EntityFrameworkCore;
using Narcissus.Security.Abstract;
using Narcissus.Security.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Narcissus.Security.EF
{
    public class UserStore<TUser, TRole, TUserKey, TRoleKey, TContext>
        :   IUserStore<TUser>,
            IUserEmailStore<TUser>,
            IUserPhoneNumberStore<TUser>
        where TUserKey : IEquatable<TUserKey>
        where TRoleKey : IEquatable<TRoleKey>
        where TUser : UserBase<TRoleKey>
        where TRole : IdentityRole<TRoleKey>
        where TContext : DbContext
    {
        private readonly TContext _context;
        public UserStore(TContext context)
        {
            _context = context;
        }

        public async Task<bool> CreateAsync(TUser user, CancellationToken cancellationToken = default(CancellationToken))
        {
            cancellationToken.ThrowIfCancellationRequested();
            _context.Add(user);
            var result = await _context.SaveChangesAsync(cancellationToken);
            return result == 0;
        }

        public Task<bool> DeactiveAsync(TUser user, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteAsync(TUser user, CancellationToken cancellationToken = default(CancellationToken))
        {
            cancellationToken.ThrowIfCancellationRequested();
            _context.Remove(user);
            var result = await _context.SaveChangesAsync(cancellationToken);
            return result == 0;
        }

        public void Dispose()
        {

        }

        public Task<TUser> FindByEmailAsync(string normalizedEmail, CancellationToken cancellationToken = default(CancellationToken))
        {

        }

        public Task<TUser> FindByPhoneNumberAsync(string normalizedEmail, CancellationToken cancellationToken = default(CancellationToken))
        {

        }

        public Task<string> GetEmailAsync(TUser user, CancellationToken cancellationToken = default(CancellationToken))
        {

        }

        public Task<bool> GetEmailConfirmedAsync(TUser user, CancellationToken cancellationToken = default(CancellationToken))
        {

        }

        public Task<bool> GetPhoneNumberAsync(TUser user, CancellationToken cancellationToken = default(CancellationToken))
        {

        }

        public Task<bool> GetPhoneNumberConfirmedAsync(TUser user, CancellationToken cancellationToken = default(CancellationToken))
        {

        }

        public Task<bool> SetEmailAsync(TUser user, string email, CancellationToken cancellationToken = default(CancellationToken))
        {

        }

        public Task<bool> SetEmailConfirmedAsync(TUser user, bool confirmed, CancellationToken cancellationToken = default(CancellationToken))
        {

        }

        public Task<bool> SetPhoneNumberAsync(TUser user, string phoneNumber, CancellationToken cancellationToken = default(CancellationToken))
        {

        }

        public Task<bool> SetPhoneNumberConfirmedAsync(TUser user, bool confirmed, CancellationToken cancellationToken = default(CancellationToken))
        {

        }

        public async Task<bool> UpdateAsync(TUser user, CancellationToken cancellationToken = default(CancellationToken))
        {
            cancellationToken.ThrowIfCancellationRequested();
            _context.Update(user);
            var result = await _context.SaveChangesAsync(cancellationToken);
            return result == 0;
        }
    }
}
