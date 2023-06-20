using MediatR;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Commands.Create
{
    public class CreateCharacterSkillCommand : IRequest<bool>
    {
        public CharacterSkillDTO CharacterSkill { get; set; }
    }
}