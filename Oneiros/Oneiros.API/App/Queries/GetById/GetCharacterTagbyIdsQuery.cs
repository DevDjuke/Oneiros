
using MediatR;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Queries.GetById
{
    public class GetCharacterTagByIdQuery : IRequest<CharacterTagDTO>
    {
        public int Id { get; set; }
    }
}