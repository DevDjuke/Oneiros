
using MediatR;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Queries.GetById
{
    public class GetCampaignCharacterByIdQuery : IRequest<CampaignCharacterDTO>
    {
        public int Id { get; set; }
    }
}