using MediatR;

namespace Oneiros.API.App.Commands.Delete
{
    public class DeleteSkillCommand : IRequest<bool>
    {
        public int Id { get; set; }
    }
}
