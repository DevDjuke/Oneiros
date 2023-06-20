
using MediatR;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Queries.GetById
{
    public class GetCharacterLanguageByIdQuery : IRequest<CharacterLanguageDTO>
    {
        public int Id { get; set; }
    }
}