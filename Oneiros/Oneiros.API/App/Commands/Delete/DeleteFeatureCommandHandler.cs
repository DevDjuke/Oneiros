using MediatR;
using Oneiros.API.Infrastructure.Services.Base;

namespace Oneiros.API.App.Commands.Delete
{
    public class DeleteFeatureCommandHandler : IRequestHandler<DeleteFeatureCommand, bool>
    {
        private IFeatureService service;

        public DeleteFeatureCommandHandler(IFeatureService service)
        {
            this.service = service;
        }

        public async Task<bool> Handle(DeleteFeatureCommand request, CancellationToken cancellationToken)
        {
            return await service.Delete(request.Id);
        }
    }
}
