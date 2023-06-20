using MediatR;

namespace Oneiros.API.App.Commands.Delete
{
    public class DeletePresetLanguageCommand : IRequest<bool>
    {
        public int Id { get; set; }
    }
}
