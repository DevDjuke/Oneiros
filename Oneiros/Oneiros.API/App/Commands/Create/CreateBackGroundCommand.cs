using MediatR;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Commands.Create
{
    public class CreateBackGroundCommand : IRequest<bool>
    {
        public BackGroundDTO BackGround { get; set; }
    }
}