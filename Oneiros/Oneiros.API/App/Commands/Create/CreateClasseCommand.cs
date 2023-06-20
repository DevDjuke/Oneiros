using MediatR;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Commands.Create
{
    public class CreateClasseCommand : IRequest<bool>
    {
        public ClasseDTO Classe { get; set; }
    }
}