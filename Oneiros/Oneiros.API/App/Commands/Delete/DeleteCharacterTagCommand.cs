using MediatR;

namespace Oneiros.API.App.Commands.Delete
{
    public class DeleteCharacterTagCommand : IRequest<bool>
    {
        public int Id { get; set; }
    }
}
