using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IUnitOfWork
    {
        IRol Rol { get; }
        IUser User { get; }
        Task<int> SaveAsync();
    }
}