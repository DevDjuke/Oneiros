using MediatR;
using Oneiros.API.Infrastructure.Services.Base;

namespace Oneiros.API.App.Commands.Delete
{
    public class DeleteBackGroundCommandHandler : IRequestHandler<DeleteBackGroundCommand, bool>
    {
        private IBackGroundService service;

        public DeleteBackGroundCommandHandler(IBackGroundService service)
        {
            this.service = service;
        }

        public async Task<bool> Handle(DeleteBackGroundCommand request, CancellationToken cancellationToken)
        {
            return await service.Delete(request.Id);
        }
    }
}
