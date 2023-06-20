using MediatR;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Commands.Update
{
    public class UpdateCharacterAbilityCommand : IRequest<bool>
    {
        public CharacterAbilityDTO CharacterAbility { get; set; }
    }
}