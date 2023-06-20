
using MediatR;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Queries.GetAll
{
    public class GetAllCharacterSkillsQuery : IRequest<IEnumerable<CharacterSkillDTO>>
    {
    }
}