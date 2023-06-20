using MediatR;
using Oneiros.API.Infrastructure.Services.Base;

namespace Oneiros.API.App.Commands.Create
{
    public class CreateSkillCommandHandler : IRequestHandler<CreateSkillCommand, bool>
    {
        private ISkillService service;

        public CreateSkillCommandHandler(ISkillService service)
        {
            this.service = service;
        }

        public async Task<bool> Handle(CreateSkillCommand request, CancellationToken cancellationToken)
        {
            return await service.Create(request.Skill);
        }
    }
}
