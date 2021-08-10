using System.Collections.Generic;
using System.Threading.Tasks;
using DotNetCourse.Dtos.Fight;
using DotNetCourse.Models;

namespace DotNetCourse.Services.FightService
{
    public interface IFightService
    {
        Task<ServiceResponse<AttackResultDto>> WeaponAttack(WeaponAttackDto request);

        Task<ServiceResponse<AttackResultDto>> SkillAttack(SkillAttackDto request);

        Task<ServiceResponse<FightResultDto>> Fight(FightRequestDto request);
        Task<ServiceResponse<List<HighscoreDto>>> GetHighscore();


    }
}