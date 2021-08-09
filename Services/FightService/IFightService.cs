using System.Threading.Tasks;
using DotNetCourse.Dtos.Fight;
using DotNetCourse.Models;

namespace DotNetCourse.Services.FightService
{
    public interface IFightService
    {
         Task<ServiceResponse<AttackResultDto>> WeaponAttack(WeaponAttackDto request);
    }
}