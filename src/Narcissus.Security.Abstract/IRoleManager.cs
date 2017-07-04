using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Narcissus.Security.Abstract
{
    public interface IRoleManager<TRole>:IDisposable where TRole:class
    {
        Task<bool> CreateAsync(TRole role);
    }
}
