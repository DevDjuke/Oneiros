using MediatR;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Commands.Create
{
    public class CreateCharacterLanguageCommand : IRequest<bool>
    {
        public CharacterLanguageDTO CharacterLanguage { get; set; }
    }
}