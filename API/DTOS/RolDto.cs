using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.DTOS;
    public class RolDto : BaseDto
    {
        public string? NombreRol { get; set; }
        public string? Description { get; set; }
    }