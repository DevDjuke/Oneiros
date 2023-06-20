using MediatR;

namespace Oneiros.API.App.Commands.Delete
{
    public class DeleteFeatureCommand : IRequest<bool>
    {
        public int Id { get; set; }
    }
}
