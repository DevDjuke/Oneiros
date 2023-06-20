using MediatR;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Commands.Create
{
    public class CreateSkillCommand : IRequest<bool>
    {
        public SkillDTO Skill { get; set; }
    }
}