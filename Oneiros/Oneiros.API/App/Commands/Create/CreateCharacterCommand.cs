using MediatR;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Commands.Create
{
    public class CreateCharacterCommand : IRequest<bool>
    {
        public CharacterDTO Character { get; set; }
    }
}