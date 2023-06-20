using MediatR;

namespace Oneiros.API.App.Commands.Delete
{
    public class DeleteBuildCommand : IRequest<bool>
    {
        public int Id { get; set; }
    }
}
