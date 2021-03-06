using System;
using AutoMapper;
using DotNetCourse.Dtos.Character;
using DotNetCourse.Dtos.Fight;
using DotNetCourse.Dtos.Item;
using DotNetCourse.Dtos.Skill;
using DotNetCourse.Dtos.Weapon;
using DotNetCourse.Models;

namespace DotNetCourse
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Character, GetCharacterDto>();
            CreateMap<AddCharacterDto, Character>();
            CreateMap<Item, GetItemDto>();
            CreateMap<AddItemDto, Item>();
            CreateMap<Weapon, GetWeaponDto>();
            CreateMap<Skill, GetSkillDto>();
            CreateMap<Character, HighscoreDto>();
        }

    }
}