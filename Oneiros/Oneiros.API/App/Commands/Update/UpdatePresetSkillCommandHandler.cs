using MediatR;
using Oneiros.API.Infrastructure.Services.Base;

namespace Oneiros.API.App.Commands.Update
{
    public class UpdatePresetSkillCommandHandler : IRequestHandler<UpdatePresetSkillCommand, bool>
    {
        private IPresetSkillService service;

        public UpdatePresetSkillCommandHandler(IPresetSkillService service)
        {
            this.service = service;
        }

        public async Task<bool> Handle(UpdatePresetSkillCommand request, CancellationToken cancellationToken)
        {
            return await service.Update(request.PresetSkill);
        }
    }
}
