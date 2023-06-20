
using MediatR;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Queries.GetById
{
    public class GetRaceByIdQuery : IRequest<RaceDTO>
    {
        public int Id { get; set; }
    }
}