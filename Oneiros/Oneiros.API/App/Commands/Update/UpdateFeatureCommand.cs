using MediatR;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Commands.Update
{
    public class UpdateFeatureCommand : IRequest<bool>
    {
        public FeatureDTO Feature { get; set; }
    }
}