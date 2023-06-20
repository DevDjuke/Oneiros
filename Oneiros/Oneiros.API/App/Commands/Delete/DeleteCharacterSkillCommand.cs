using MediatR;

namespace Oneiros.API.App.Commands.Delete
{
    public class DeleteCharacterSkillCommand : IRequest<bool>
    {
        public int Id { get; set; }
    }
}
