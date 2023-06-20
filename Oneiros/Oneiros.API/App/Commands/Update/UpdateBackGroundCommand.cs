using MediatR;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Commands.Update
{
    public class UpdateBackGroundCommand : IRequest<bool>
    {
        public BackGroundDTO BackGround { get; set; }
    }
}