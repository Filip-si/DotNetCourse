
using System.Collections.Generic;
using System.Threading.Tasks;
using DotNetCourse.Dtos.Character;
using DotNetCourse.Models;

namespace DotNetCourse.Services.CharacterService
{
    public interface ICharacterService
    {
        Task<ServiceResponse<List<GetCharacterDto>>> GetAllCharacters();
        Task<ServiceResponse<GetCharacterDto>> GetCharacterById(int id);

        Task<ServiceResponse<List<GetCharacterDto>>> AddCharacter(AddCharacterDto newCharacter);

        Task<ServiceResponse<GetCharacterDto>> UpdateCharacter(UpdateCharacterDto updateCharacterDto);

        Task<ServiceResponse<List<GetCharacterDto>>> DeleteCharacter(int id);
         
    }
}