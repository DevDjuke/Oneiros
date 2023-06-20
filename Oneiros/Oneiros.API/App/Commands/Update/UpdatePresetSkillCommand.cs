using MediatR;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Commands.Update
{
    public class UpdatePresetSkillCommand : IRequest<bool>
    {
        public PresetSkillDTO PresetSkill { get; set; }
    }
}