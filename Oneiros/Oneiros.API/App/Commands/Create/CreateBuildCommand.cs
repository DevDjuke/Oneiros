using MediatR;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Commands.Create
{
    public class CreateBuildCommand : IRequest<bool>
    {
        public BuildDTO Build { get; set; }
    }
}