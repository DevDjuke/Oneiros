
using MediatR;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Queries.GetById
{
    public class GetCharacterFeatureByIdQuery : IRequest<CharacterFeatureDTO>
    {
        public int Id { get; set; }
    }
}