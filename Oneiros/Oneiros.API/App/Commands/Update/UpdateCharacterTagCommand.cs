using MediatR;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Commands.Update
{
    public class UpdateCharacterTagCommand : IRequest<bool>
    {
        public CharacterTagDTO CharacterTag { get; set; }
    }
}