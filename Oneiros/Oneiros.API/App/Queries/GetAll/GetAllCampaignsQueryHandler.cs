
using MediatR;
using Oneiros.API.Infrastructure.Services.Base;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Queries.GetAll
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
