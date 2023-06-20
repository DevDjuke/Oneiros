using MediatR;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Commands.Create
{
    public class CreateCharacterAbilityCommand : IRequest<bool>
    {
        public CharacterAbilityDTO CharacterAbility { get; set; }
    }
}