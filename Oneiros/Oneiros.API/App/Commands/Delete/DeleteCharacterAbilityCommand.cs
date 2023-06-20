using MediatR;

namespace Oneiros.API.App.Commands.Delete
{
    public class DeleteCharacterAbilityCommand : IRequest<bool>
    {
        public int Id { get; set; }
    }
}
