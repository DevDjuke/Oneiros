using MediatR;

namespace Oneiros.API.App.Commands.Delete
{
    public class DeleteLanguageCommand : IRequest<bool>
    {
        public int Id { get; set; }
    }
}
