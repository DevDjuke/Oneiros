using MediatR;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Commands.Update
{
    public class UpdatePresetCommand : IRequest<bool>
    {
        public PresetDTO Preset { get; set; }
    }
}