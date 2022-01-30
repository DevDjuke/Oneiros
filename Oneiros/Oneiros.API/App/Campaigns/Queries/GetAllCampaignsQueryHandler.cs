using MediatR;
using Oneiros.Data.DTO;
using Oneiros.Infrastructure.Services;

namespace Oneiros.API.App.Campaigns.Queries
{
    public class GetAllCampaignsQueryHandler : IRequestHandler<GetAllCampaignsQuery, IEnumerable<CampaignDTO>>
    {
        private ICampaignService service;

        public GetAllCampaignsQueryHandler(ICampaignService service)
        {
            this.service = service;
        }

        public async Task<IEnumerable<CampaignDTO>> Handle(GetAllCampaignsQuery request, CancellationToken cancellationToken)
        {
            return (await service.GetAll()).ToList();    
        }
    }
}
