using System;
using AutoMapper;
using DotNetCourse.Dtos.Character;
using DotNetCourse.Models;

namespace DotNetCourse
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Character, GetCharacterDto>();
            CreateMap<AddCharacterDto, Character>();
        }

    }
}