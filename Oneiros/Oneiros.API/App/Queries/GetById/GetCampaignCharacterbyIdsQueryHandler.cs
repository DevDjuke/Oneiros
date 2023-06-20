using MediatR;
using Oneiros.API.Infrastructure.Services.Base;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Queries.GetById
{
    public class GetCampaignCharacterByIdQueryHandler : IRequestHandler<GetCampaignCharacterByIdQuery, CampaignCharacterDTO>
    {
        private ICampaignCharacterService service;

        public GetCampaignCharacterByIdQueryHandler(ICampaignCharacterService service)
        {
            this.service = service;
        }

        public async Task<CampaignCharacterDTO> Handle(GetCampaignCharacterByIdQuery request, CancellationToken cancellationToken)
        {
            return await service.GetById(request.Id);
        }
    }
}
