
using MediatR;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Queries.GetById
{
    public class GetRaceAbilityByIdQuery : IRequest<RaceAbilityDTO>
    {
        public int Id { get; set; }
    }
}