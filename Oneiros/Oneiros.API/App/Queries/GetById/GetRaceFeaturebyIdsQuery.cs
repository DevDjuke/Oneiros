
using MediatR;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Queries.GetById
{
    public class GetRaceFeatureByIdQuery : IRequest<RaceFeatureDTO>
    {
        public int Id { get; set; }
    }
}