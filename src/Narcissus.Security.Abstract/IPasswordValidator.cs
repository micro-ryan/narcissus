using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Narcissus.Security.Abstract
{
    public interface IPasswordValidator<TUser> where TUser:class
    {
        Task<bool> ValidateAsync(TUser user, string password);
    }
}
