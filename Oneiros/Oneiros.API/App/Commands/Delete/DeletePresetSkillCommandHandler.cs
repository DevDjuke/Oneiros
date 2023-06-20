using MediatR;
using Oneiros.API.Infrastructure.Services.Base;

namespace Oneiros.API.App.Commands.Delete
{
    public class DeletePresetSkillCommandHandler : IRequestHandler<DeletePresetSkillCommand, bool>
    {
        private IPresetSkillService service;

        public DeletePresetSkillCommandHandler(IPresetSkillService service)
        {
            this.service = service;
        }

        public async Task<bool> Handle(DeletePresetSkillCommand request, CancellationToken cancellationToken)
        {
            return await service.Delete(request.Id);
        }
    }
}
