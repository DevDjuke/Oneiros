using MediatR;
using Oneiros.API.Infrastructure.Services.Base;

namespace Oneiros.API.App.Commands.Update
{
    public class UpdateFeatureCommandHandler : IRequestHandler<UpdateFeatureCommand, bool>
    {
        private IFeatureService service;

        public UpdateFeatureCommandHandler(IFeatureService service)
        {
            this.service = service;
        }

        public async Task<bool> Handle(UpdateFeatureCommand request, CancellationToken cancellationToken)
        {
            return await service.Update(request.Feature);
        }
    }
}
