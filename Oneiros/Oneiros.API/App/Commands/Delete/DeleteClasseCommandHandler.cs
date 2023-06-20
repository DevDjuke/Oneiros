using MediatR;
using Oneiros.API.Infrastructure.Services.Base;

namespace Oneiros.API.App.Commands.Delete
{
    public class DeleteClasseCommandHandler : IRequestHandler<DeleteClasseCommand, bool>
    {
        private IClasseService service;

        public DeleteClasseCommandHandler(IClasseService service)
        {
            this.service = service;
        }

        public async Task<bool> Handle(DeleteClasseCommand request, CancellationToken cancellationToken)
        {
            return await service.Delete(request.Id);
        }
    }
}
