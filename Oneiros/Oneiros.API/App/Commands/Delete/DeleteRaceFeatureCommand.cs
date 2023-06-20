using MediatR;

namespace Oneiros.API.App.Commands.Delete
{
    public class DeleteRaceFeatureCommand : IRequest<bool>
    {
        public int Id { get; set; }
    }
}
