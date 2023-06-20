using MediatR;

namespace Oneiros.API.App.Commands.Delete
{
    public class DeleteNonPlayerBuildCommand : IRequest<bool>
    {
        public int Id { get; set; }
    }
}
