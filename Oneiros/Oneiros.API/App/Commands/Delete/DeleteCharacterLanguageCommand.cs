using MediatR;

namespace Oneiros.API.App.Commands.Delete
{
    public class DeleteCharacterLanguageCommand : IRequest<bool>
    {
        public int Id { get; set; }
    }
}
