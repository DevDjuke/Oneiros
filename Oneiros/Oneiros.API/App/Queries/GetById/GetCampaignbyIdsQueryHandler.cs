using MediatR;
using Oneiros.API.Infrastructure.Services.Base;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Queries.GetById
{
    public class GetCampaignByIdQueryHandler : IRequestHandler<GetCampaignByIdQuery, CampaignDTO>
    {
        private ICampaignService service;

        public GetCampaignByIdQueryHandler(ICampaignService service)
        {
            this.service = service;
        }

        public async Task<CampaignDTO> Handle(GetCampaignByIdQuery request, CancellationToken cancellationToken)
        {
            return await service.GetById(request.Id);
        }
    }
}
