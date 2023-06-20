using MediatR;

namespace Oneiros.API.App.Commands.Delete
{
    public class DeleteAbilityCommand : IRequest<bool>
    {
        public int Id { get; set; }
    }
}
