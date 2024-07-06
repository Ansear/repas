using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;
using Persistence;

namespace APP.Repository;
    public class UserRepository : GenericRepository<User>, IUser
    {
        public UserRepository(ApiContext context) : base(context)
        {
        }
    }