using MediatR;

namespace Oneiros.API.App.Commands.Delete
{
    public class DeleteTagCommand : IRequest<bool>
    {
        public int Id { get; set; }
    }
}
