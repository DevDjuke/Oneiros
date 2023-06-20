using MediatR;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Commands.Create
{
    public class CreateRaceCommand : IRequest<bool>
    {
        public RaceDTO Race { get; set; }
    }
}