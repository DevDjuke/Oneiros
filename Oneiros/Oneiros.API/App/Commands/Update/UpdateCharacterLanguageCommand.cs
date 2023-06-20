using MediatR;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Commands.Update
{
    public class UpdateCharacterLanguageCommand : IRequest<bool>
    {
        public CharacterLanguageDTO CharacterLanguage { get; set; }
    }
}