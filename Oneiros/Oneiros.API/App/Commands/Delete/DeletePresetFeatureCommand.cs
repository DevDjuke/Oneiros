using MediatR;

namespace Oneiros.API.App.Commands.Delete
{
    public class DeletePresetFeatureCommand : IRequest<bool>
    {
        public int Id { get; set; }
    }
}
