
using MediatR;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Queries.GetById
{
    public class GetCharacterAbilityByIdQuery : IRequest<CharacterAbilityDTO>
    {
        public int Id { get; set; }
    }
}