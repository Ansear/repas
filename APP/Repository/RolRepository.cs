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
        public RolRepository(ApiContext context) : base(context)
        {
        }
    }