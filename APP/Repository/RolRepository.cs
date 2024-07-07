using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;
using Persistence;

namespace APP.Repository;
    public class RolRepository : GenericRepository<Rol>, IRol
    {
        private readonly ApiContext _context;
        public RolRepository(ApiContext context) : base(context)
        {
            _context = context;
        }

        // public override async Task<IEnumerable<Rol>> GetAllAsync()
        // {
        //     return await _context.Rol
        //                     .Include(p => p.)
        // }
    }