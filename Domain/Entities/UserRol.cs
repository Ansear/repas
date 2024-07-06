﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    internal class UserRol
    {
        public int UserId { get; set; }
        public User? User { get; set; }

        public int RolId { get; set; }
        public Rol? Rol { get; set; }
    }
}
