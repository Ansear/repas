﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class User : BaseEntity
    {
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? Tipo_Documento { get; set; }
        public string? Num_Documento { get; set; }
        public string? Correo { get; set; }
        public string? Usuario { get; set; }
        public string? Contraseña { get; set; }
        public ICollection<Rol> Roles { get; set; } = new HashSet<Rol>();
        public ICollection<UserRol>? UserRoles { get; set; } = new HashSet<UserRol>();
    }
}
