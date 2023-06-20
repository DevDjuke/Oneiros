using MediatR;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Commands.Create
{
    public class CreatePresetAbilityCommand : IRequest<bool>
    {
        public PresetAbilityDTO PresetAbility { get; set; }
    }
}