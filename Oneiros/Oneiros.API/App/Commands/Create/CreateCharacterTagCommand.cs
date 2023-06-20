using MediatR;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Commands.Create
{
    public class CreateCharacterTagCommand : IRequest<bool>
    {
        public CharacterTagDTO CharacterTag { get; set; }
    }
}