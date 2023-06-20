using MediatR;
using Oneiros.API.Infrastructure.Services.Base;

namespace Oneiros.API.App.Commands.Delete
{
    public class DeleteRaceFeatureCommandHandler : IRequestHandler<DeleteRaceFeatureCommand, bool>
    {
        private IRaceFeatureService service;

        public DeleteRaceFeatureCommandHandler(IRaceFeatureService service)
        {
            this.service = service;
        }

        public async Task<bool> Handle(DeleteRaceFeatureCommand request, CancellationToken cancellationToken)
        {
            return await service.Delete(request.Id);
        }
    }
}
