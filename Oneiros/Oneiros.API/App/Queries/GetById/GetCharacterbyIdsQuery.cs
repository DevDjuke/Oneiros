
using MediatR;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Queries.GetById
{
    public class GetCharacterByIdQuery : IRequest<CharacterDTO>
    {
        public int Id { get; set; }
    }
}