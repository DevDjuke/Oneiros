using MediatR;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Commands.Create
{
    public class CreatePresetLanguageCommand : IRequest<bool>
    {
        public PresetLanguageDTO PresetLanguage { get; set; }
    }
}