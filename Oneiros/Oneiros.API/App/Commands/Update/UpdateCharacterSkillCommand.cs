using MediatR;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Commands.Update
{
    public class UpdateCharacterSkillCommand : IRequest<bool>
    {
        public CharacterSkillDTO CharacterSkill { get; set; }
    }
}