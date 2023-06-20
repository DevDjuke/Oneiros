using MediatR;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Commands.Update
{
    public class UpdateCharacterFeatureCommand : IRequest<bool>
    {
        public CharacterFeatureDTO CharacterFeature { get; set; }
    }
}