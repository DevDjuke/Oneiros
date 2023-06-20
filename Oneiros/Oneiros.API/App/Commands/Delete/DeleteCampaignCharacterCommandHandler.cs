using MediatR;
using Oneiros.API.Infrastructure.Services.Base;

namespace Oneiros.API.App.Commands.Delete
{
    public class DeleteCampaignCharacterCommandHandler : IRequestHandler<DeleteCampaignCharacterCommand, bool>
    {
        private ICampaignCharacterService service;

        public DeleteCampaignCharacterCommandHandler(ICampaignCharacterService service)
        {
            this.service = service;
        }

        public async Task<bool> Handle(DeleteCampaignCharacterCommand request, CancellationToken cancellationToken)
        {
            return await service.Delete(request.Id);
        }
    }
}
