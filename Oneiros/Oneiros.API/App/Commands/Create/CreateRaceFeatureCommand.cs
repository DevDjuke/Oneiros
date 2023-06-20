using MediatR;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Commands.Create
{
    public class CreateRaceFeatureCommand : IRequest<bool>
    {
        public RaceFeatureDTO RaceFeature { get; set; }
    }
}