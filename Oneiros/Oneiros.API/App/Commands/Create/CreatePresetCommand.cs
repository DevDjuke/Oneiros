using MediatR;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Commands.Create
{
    public class CreatePresetCommand : IRequest<bool>
    {
        public PresetDTO Preset { get; set; }
    }
}