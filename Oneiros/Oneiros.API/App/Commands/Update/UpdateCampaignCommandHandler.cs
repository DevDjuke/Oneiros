using MediatR;
using Oneiros.API.Infrastructure.Services.Base;

namespace Oneiros.API.App.Commands.Update
{
    public class UpdateCampaignCommandHandler : IRequestHandler<UpdateCampaignCommand, bool>
    {
        private ICampaignService service;

        public UpdateCampaignCommandHandler(ICampaignService service)
        {
            this.service = service;
        }

        public async Task<bool> Handle(UpdateCampaignCommand request, CancellationToken cancellationToken)
        {
            return await service.Update(request.Campaign);
        }
    }
}
