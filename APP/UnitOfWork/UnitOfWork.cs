using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APP.Repository;
using Domain.Interfaces;
using Persistence;

namespace APP.UnitOfWork;
public class UnitOfWork : IUnitOfWork, IDisposable
{
    private readonly ApiContext _context;
    private UserRepository? _users;
    private RolRepository? _roles;

    public UnitOfWork(ApiContext context)
    {
        _context = context;
    }
    public IUser User
    {
        get
        {
            _users ??= new UserRepository(_context);
            return _users;
        }
    }

    public IRol Rol
    {
        get
        {
            _roles ??= new RolRepository(_context);
            return _roles;
        }
    }

    public async Task<int> SaveAsync()
    {
        return await _context.SaveChangesAsync();
    }
    public void Dispose()
    {
        _context.Dispose();
    }
}