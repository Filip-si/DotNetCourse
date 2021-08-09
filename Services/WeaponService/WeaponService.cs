using System;
using System.Security.Claims;
using System.Threading.Tasks;
using AutoMapper;
using DotNetCourse.Data;
using DotNetCourse.Dtos.Character;
using DotNetCourse.Dtos.Weapon;
using DotNetCourse.Models;
using DotNetCourse.Services.WeaponService;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace DotNetCourse.Services.WeaponService
{
    public class WeaponService : IWeaponService
    {

        private readonly DataContext _context;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IMapper _mapper;

        public WeaponService(DataContext context, IHttpContextAccessor httpContextAccessor,IMapper mapper)
        {
            _context = context;
            _httpContextAccessor = httpContextAccessor;
            _mapper = mapper;
        }
        public async Task<ServiceResponse<GetCharacterDto>> AddWeapon(AddWeaponDto newWeapon)
        {
            var response = new ServiceResponse<GetCharacterDto>();
            try
            {
                var character = await _context.Characters
                    .FirstOrDefaultAsync(c => c.Id == newWeapon.CharacterId && // belongs weapon to which character
                                         c.User.Id ==  int.Parse(_httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier))); // find user which has the character which has that weapon

                if(character == null)
                {
                    response.Success = false;
                    response.Message = "Character not found";
                    return response;
                }
                var weapon = new Weapon
                {
                    Name = newWeapon.Name,
                    Damage = newWeapon.Damage,
                    Character = character                    
                };

                _context.Weapons.Add(weapon);
                await _context.SaveChangesAsync();

                response.Data = _mapper.Map<GetCharacterDto>(character);

            }
            catch(Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
            }
            return response;
        }
    }
}