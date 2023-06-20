using MediatR;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Commands.Update
{
    public class UpdatePresetAbilityCommand : IRequest<bool>
    {
        public PresetAbilityDTO PresetAbility { get; set; }
    }
}