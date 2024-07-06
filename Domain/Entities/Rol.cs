using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    internal class Rol : BaseEntity
    {
        public string? NombreRol { get; set; }
        public string? Description { get; set; }
        public ICollection<UserRol>? UserRoles { get; set; }
    }
}
