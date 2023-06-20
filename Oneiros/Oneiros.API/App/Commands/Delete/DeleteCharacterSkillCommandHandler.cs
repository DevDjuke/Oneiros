using MediatR;
using Oneiros.API.Infrastructure.Services.Base;

namespace Oneiros.API.App.Commands.Delete
{
    public class DeleteCharacterSkillCommandHandler : IRequestHandler<DeleteCharacterSkillCommand, bool>
    {
        private ICharacterSkillService service;

        public DeleteCharacterSkillCommandHandler(ICharacterSkillService service)
        {
            this.service = service;
        }

        public async Task<bool> Handle(DeleteCharacterSkillCommand request, CancellationToken cancellationToken)
        {
            return await service.Delete(request.Id);
        }
    }
}
