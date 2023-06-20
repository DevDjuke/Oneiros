using MediatR;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Commands.Create
{
    public class CreateNonPlayerBuildCommand : IRequest<bool>
    {
        public NonPlayerBuildDTO NonPlayerBuild { get; set; }
    }
}