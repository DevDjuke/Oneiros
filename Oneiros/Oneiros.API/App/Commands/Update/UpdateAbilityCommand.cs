using MediatR;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Commands.Update
{
    public class UpdateAbilityCommand : IRequest<bool>
    {
        public AbilityDTO Ability { get; set; }
    }
}