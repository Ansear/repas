using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.DTOS;
public class AddRoleDto
{
    [Required]
    public string? UserName {get; set;}
    [Required]
    public string? Password {get; set;}
    [Required]
    public string? Role {get; set;}
}