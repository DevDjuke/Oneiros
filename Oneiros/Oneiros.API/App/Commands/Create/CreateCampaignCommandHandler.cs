using MediatR;
using Oneiros.API.Infrastructure.Services.Base;

namespace Oneiros.API.App.Commands.Create
{
    public class CreateCampaignCommandHandler : IRequestHandler<CreateCampaignCommand, bool>
    {
        private ICampaignService service;

        public CreateCampaignCommandHandler(ICampaignService service)
        {
            this.service = service;
        }

        public async Task<bool> Handle(CreateCampaignCommand request, CancellationToken cancellationToken)
        {
            return await service.Create(request.Campaign);
        }
    }
}
