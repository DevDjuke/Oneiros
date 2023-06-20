using MediatR;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Commands.Update
{
    public class UpdateCharacterCommand : IRequest<bool>
    {
        public CharacterDTO Character { get; set; }
    }
}