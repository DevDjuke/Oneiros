using MediatR;
using Oneiros.API.Infrastructure.Services.Base;

namespace Oneiros.API.App.Commands.Delete
{
    public class DeleteCharacterTagCommandHandler : IRequestHandler<DeleteCharacterTagCommand, bool>
    {
        private ICharacterTagService service;

        public DeleteCharacterTagCommandHandler(ICharacterTagService service)
        {
            this.service = service;
        }

        public async Task<bool> Handle(DeleteCharacterTagCommand request, CancellationToken cancellationToken)
        {
            return await service.Delete(request.Id);
        }
    }
}
