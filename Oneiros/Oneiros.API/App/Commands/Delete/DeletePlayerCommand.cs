using MediatR;

namespace Oneiros.API.App.Commands.Delete
{
    public class DeletePlayerCommand : IRequest<bool>
    {
        public int Id { get; set; }
    }
}
