using MediatR;

namespace Oneiros.API.App.Commands.Delete
{
    public class DeleteCharacterFeatureCommand : IRequest<bool>
    {
        public int Id { get; set; }
    }
}
