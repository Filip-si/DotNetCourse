using System.Threading.Tasks;
using DotNetCourse.Dtos.Fight;
using DotNetCourse.Models;
using DotNetCourse.Services.FightService;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCourse.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FightController : ControllerBase
    {
        private readonly IFightService _fightService;

        public FightController(IFightService fightService)
        {
            _fightService = fightService;
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<AttackResultDto>>> WeaponAttack(WeaponAttackDto request)
        {
            return Ok(await _fightService.WeaponAttack(request));
        }

        
    }
}