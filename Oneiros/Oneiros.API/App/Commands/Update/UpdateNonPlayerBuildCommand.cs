using MediatR;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Commands.Update
{
    public class UpdateNonPlayerBuildCommand : IRequest<bool>
    {
        public NonPlayerBuildDTO NonPlayerBuild { get; set; }
    }
}