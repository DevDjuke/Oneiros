using MediatR;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Commands.Create
{
    public class CreateCharacterFeatureCommand : IRequest<bool>
    {
        public CharacterFeatureDTO CharacterFeature { get; set; }
    }
}