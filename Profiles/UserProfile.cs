using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DotNetCoreRestApi.DTO;
using DotNetCoreRestApi.Models;

namespace DotNetCoreRestApi.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<UserData, UserDetailsReadDTO>();
            CreateMap<UserDetailsCreateDTO, UserData>();
            CreateMap<UserDetailsUpdateDTO, UserData>();
            CreateMap<UserData,UserDetailsUpdateDTO>();
        }
    }
}
