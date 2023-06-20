using MediatR;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Commands.Create
{
    public class CreateAbilityCommand : IRequest<bool>
    {
        public AbilityDTO Ability { get; set; }
    }
}