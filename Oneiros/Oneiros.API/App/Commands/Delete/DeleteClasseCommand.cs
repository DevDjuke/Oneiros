using MediatR;

namespace Oneiros.API.App.Commands.Delete
{
    public class DeleteClasseCommand : IRequest<bool>
    {
        public int Id { get; set; }
    }
}
