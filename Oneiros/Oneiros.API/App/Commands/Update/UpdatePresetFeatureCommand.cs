using MediatR;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Commands.Update
{
    public class UpdatePresetFeatureCommand : IRequest<bool>
    {
        public PresetFeatureDTO PresetFeature { get; set; }
    }
}