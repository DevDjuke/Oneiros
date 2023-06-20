using MediatR;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Commands.Update
{
    public class UpdateClasseCommand : IRequest<bool>
    {
        public ClasseDTO Classe { get; set; }
    }
}