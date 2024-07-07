using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.DTOS;

namespace API.Services;
public interface IUserServices
{
    Task<string> RegisterAsync(RegisterDto model);
    Task<DataUserDto> GetTokenAsync(LoginDto model);
    Task<string> AddRoleAsync(AddRoleDto model);
}