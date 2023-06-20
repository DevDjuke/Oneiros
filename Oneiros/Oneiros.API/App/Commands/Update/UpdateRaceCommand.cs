using MediatR;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Commands.Update
{
    public class UpdateRaceCommand : IRequest<bool>
    {
        public RaceDTO Race { get; set; }
    }
}