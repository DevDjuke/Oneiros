using MediatR;

namespace Oneiros.API.App.Commands.Delete
{
    public class DeletePresetSkillCommand : IRequest<bool>
    {
        public int Id { get; set; }
    }
}
