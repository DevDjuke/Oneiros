using MediatR;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Commands.Update
{
    public class UpdateRaceAbilityCommand : IRequest<bool>
    {
        public RaceAbilityDTO RaceAbility { get; set; }
    }
}