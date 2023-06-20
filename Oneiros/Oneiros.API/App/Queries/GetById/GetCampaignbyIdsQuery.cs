
using MediatR;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Queries.GetById
{
    public class GetCampaignByIdQuery : IRequest<CampaignDTO>
    {
        public int Id { get; set; }
    }
}