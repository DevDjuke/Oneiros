
using MediatR;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Queries.GetAll
{
    public class GetAllRacesQuery : IRequest<IEnumerable<RaceDTO>>
    {
    }
}