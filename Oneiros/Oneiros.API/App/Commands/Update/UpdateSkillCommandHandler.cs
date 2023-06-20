using MediatR;
using Oneiros.API.Infrastructure.Services.Base;

namespace Oneiros.API.App.Commands.Update
{
    public class UpdateSkillCommandHandler : IRequestHandler<UpdateSkillCommand, bool>
    {
        private ISkillService service;

        public UpdateSkillCommandHandler(ISkillService service)
        {
            this.service = service;
        }

        public async Task<bool> Handle(UpdateSkillCommand request, CancellationToken cancellationToken)
        {
            return await service.Update(request.Skill);
        }
    }
}
