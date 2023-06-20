using MediatR;

namespace Oneiros.API.App.Commands.Delete
{
    public class DeletePresetCommand : IRequest<bool>
    {
        public int Id { get; set; }
    }
}
