using MediatR;

namespace Oneiros.API.App.Commands.Delete
{
    public class DeleteItemCommand : IRequest<bool>
    {
        public int Id { get; set; }
    }
}
