using MediatR;

namespace Oneiros.API.App.Commands.Delete
{
    public class DeleteCharacterCommand : IRequest<bool>
    {
        public int Id { get; set; }
    }
}