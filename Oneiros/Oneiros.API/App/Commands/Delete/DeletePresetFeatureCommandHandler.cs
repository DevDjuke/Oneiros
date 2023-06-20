using MediatR;
using Oneiros.API.Infrastructure.Services.Base;

namespace Oneiros.API.App.Commands.Delete
{
    public class DeletePresetFeatureCommandHandler : IRequestHandler<DeletePresetFeatureCommand, bool>
    {
        private IPresetFeatureService service;

        public DeletePresetFeatureCommandHandler(IPresetFeatureService service)
        {
            this.service = service;
        }

        public async Task<bool> Handle(DeletePresetFeatureCommand request, CancellationToken cancellationToken)
        {
            return await service.Delete(request.Id);
        }
    }
}
