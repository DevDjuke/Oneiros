using MediatR;
using Oneiros.API.Infrastructure.Services.Base;

namespace Oneiros.API.App.Commands.Create
{
    public class CreateCharacterSkillCommandHandler : IRequestHandler<CreateCharacterSkillCommand, bool>
    {
        private ICharacterSkillService service;

        public CreateCharacterSkillCommandHandler(ICharacterSkillService service)
        {
            this.service = service;
        }

        public async Task<bool> Handle(CreateCharacterSkillCommand request, CancellationToken cancellationToken)
        {
            return await service.Create(request.CharacterSkill);
        }
    }
}
