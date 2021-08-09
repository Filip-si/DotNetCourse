using System.Threading.Tasks;
using DotNetCourse.Dtos.Character;
using DotNetCourse.Models;
using DotNetCourse.Dtos.Weapon;

namespace DotNetCourse.Services.WeaponService
{
    public interface IWeaponService
    {
         Task<ServiceResponse<GetCharacterDto>> AddWeapon(AddWeaponDto newWeapon);
    }
}