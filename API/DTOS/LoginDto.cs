using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.DTOS
{
    public class LoginDto
    {
        public string? Usuario { get; set; }
        public string? Contraseña { get; set; }
    }
}