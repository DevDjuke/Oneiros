using MediatR;
using Oneiros.API.Infrastructure.Services.Base;

namespace Oneiros.API.App.Commands.Create
{
    public class CreatePresetSkillCommandHandler : IRequestHandler<CreatePresetSkillCommand, bool>
    {
        private IPresetSkillService service;

        public CreatePresetSkillCommandHandler(IPresetSkillService service)
        {
            this.service = service;
        }

        public async Task<bool> Handle(CreatePresetSkillCommand request, CancellationToken cancellationToken)
        {
            return await service.Create(request.PresetSkill);
        }
    }
}
