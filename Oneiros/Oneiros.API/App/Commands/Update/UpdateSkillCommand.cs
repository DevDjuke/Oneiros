using MediatR;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Commands.Update
{
    public class UpdateSkillCommand : IRequest<bool>
    {
        public SkillDTO Skill { get; set; }
    }
}