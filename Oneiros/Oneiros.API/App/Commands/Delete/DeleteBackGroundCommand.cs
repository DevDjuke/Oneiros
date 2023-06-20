using MediatR;

namespace Oneiros.API.App.Commands.Delete
{
    public class DeleteBackGroundCommand : IRequest<bool>
    {
        public int Id { get; set; }
    }
}
