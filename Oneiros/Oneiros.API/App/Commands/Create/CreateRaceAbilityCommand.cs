using MediatR;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Commands.Create
{
    public class CreateRaceAbilityCommand : IRequest<bool>
    {
        public RaceAbilityDTO RaceAbility { get; set; }
    }
}