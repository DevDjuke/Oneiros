using MediatR;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Commands.Create
{
    public class CreatePresetSkillCommand : IRequest<bool>
    {
        public PresetSkillDTO PresetSkill { get; set; }
    }
}