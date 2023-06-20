using MediatR;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Commands.Create
{
    public class CreatePresetFeatureCommand : IRequest<bool>
    {
        public PresetFeatureDTO PresetFeature { get; set; }
    }
}