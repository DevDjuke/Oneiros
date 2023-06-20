
using MediatR;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Queries.GetById
{
    public class GetCharacterSkillByIdQuery : IRequest<CharacterSkillDTO>
    {
        public int Id { get; set; }
    }
}