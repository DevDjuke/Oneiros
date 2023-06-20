using MediatR;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Commands.Create
{
    public class CreateFeatureCommand : IRequest<bool>
    {
        public FeatureDTO Feature { get; set; }
    }
}