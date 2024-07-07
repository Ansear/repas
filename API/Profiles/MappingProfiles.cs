using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.DTOS;
using AutoMapper;
using Domain.Entities;

namespace API.Profiles;
public class MappingProfiles : Profile
{
    public MappingProfiles(){
        CreateMap<Rol,RolDto>().ReverseMap();
        CreateMap<User,UserDto>().ReverseMap();
    }
}
