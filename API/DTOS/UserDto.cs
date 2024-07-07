using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.DTOS;
public class UserDto : BaseDto
{
    public string? Nombre { get; set; }
    public string? Apellido { get; set; }
    public string? Tipo_Documento { get; set; }
    public string? Num_Documento { get; set; }
    public string? Correo { get; set; }
    public string? Usuario { get; set; }
    public string? Contraseña { get; set; }
}