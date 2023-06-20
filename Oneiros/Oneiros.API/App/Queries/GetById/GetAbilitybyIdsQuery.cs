
using MediatR;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Queries.GetById
{
    public class GetAbilityByIdQuery : IRequest<AbilityDTO>
    {
        public int Id { get; set; }
    }
}