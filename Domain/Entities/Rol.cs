using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Rol : BaseEntity
    {
        public string? NombreRol { get; set; }
        public string? Description { get; set; }
        public ICollection<User> Users { get; set; } = new HashSet<User>();
        public ICollection<UserRol>? UserRoles { get; set; }= new HashSet<UserRol>();
    }
}
