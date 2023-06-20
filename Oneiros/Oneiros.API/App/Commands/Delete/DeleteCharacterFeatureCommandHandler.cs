using MediatR;
using Oneiros.API.Infrastructure.Services.Base;

namespace Oneiros.API.App.Commands.Delete
{
    public class DeleteCharacterFeatureCommandHandler : IRequestHandler<DeleteCharacterFeatureCommand, bool>
    {
        private ICharacterFeatureService service;

        public DeleteCharacterFeatureCommandHandler(ICharacterFeatureService service)
        {
            this.service = service;
        }

        public async Task<bool> Handle(DeleteCharacterFeatureCommand request, CancellationToken cancellationToken)
        {
            return await service.Delete(request.Id);
        }
    }
}
