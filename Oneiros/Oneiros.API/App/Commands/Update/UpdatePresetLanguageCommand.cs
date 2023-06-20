using MediatR;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Commands.Update
{
    public class UpdatePresetLanguageCommand : IRequest<bool>
    {
        public PresetLanguageDTO PresetLanguage { get; set; }
    }
}