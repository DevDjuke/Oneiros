using MediatR;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Commands.Update
{
    public class UpdateBuildCommand : IRequest<bool>
    {
        public BuildDTO Build { get; set; }
    }
}