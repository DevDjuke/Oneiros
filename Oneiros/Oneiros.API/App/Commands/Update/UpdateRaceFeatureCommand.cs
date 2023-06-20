using MediatR;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Commands.Update
{
    public class UpdateRaceFeatureCommand : IRequest<bool>
    {
        public RaceFeatureDTO RaceFeature { get; set; }
    }
}