using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Narcissus.Security.Abstract
{
    public interface IPasswordHasher<TUser> where TUser:class
    {
        Task<string> HashPassword(TUser user, string password);
        Task<bool> VerifyHashedPassword(TUser user, string hashedPassword, string providedPassword);
    }
}
