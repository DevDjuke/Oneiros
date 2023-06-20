using MediatR;
using Oneiros.API.Infrastructure.Services.Base;

namespace Oneiros.API.App.Commands.Update
{
    public class UpdateCharacterSkillCommandHandler : IRequestHandler<UpdateCharacterSkillCommand, bool>
    {
        private ICharacterSkillService service;

        public UpdateCharacterSkillCommandHandler(ICharacterSkillService service)
        {
            this.service = service;
        }

        public async Task<bool> Handle(UpdateCharacterSkillCommand request, CancellationToken cancellationToken)
        {
            return await service.Update(request.CharacterSkill);
        }
    }
}
