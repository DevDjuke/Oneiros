using MediatR;

namespace Oneiros.API.App.Commands.Delete
{
    public class DeletePresetAbilityCommand : IRequest<bool>
    {
        public int Id { get; set; }
    }
}
