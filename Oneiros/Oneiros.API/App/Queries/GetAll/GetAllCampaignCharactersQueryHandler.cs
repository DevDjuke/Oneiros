
using MediatR;
using Oneiros.API.Infrastructure.Services.Base;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Queries.GetAll
{
    public class GetAllCampaignCharactersQueryHandler : IRequestHandler<GetAllCampaignCharactersQuery, IEnumerable<CampaignCharacterDTO>>
    {
        private ICampaignCharacterService service;

        public GetAllCampaignCharactersQueryHandler(ICampaignCharacterService service)
        {
            this.service = service;
        }

        public async Task<IEnumerable<CampaignCharacterDTO>> Handle(GetAllCampaignCharactersQuery request, CancellationToken cancellationToken)
        {
            return (await service.GetAll()).ToList();
        }
    }
}
