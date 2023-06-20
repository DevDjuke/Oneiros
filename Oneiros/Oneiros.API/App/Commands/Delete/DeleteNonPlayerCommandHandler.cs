using MediatR;
using Oneiros.API.Infrastructure.Services.Base;

namespace Oneiros.API.App.Commands.Delete
{
    public class DeleteNonPlayerCommandHandler : IRequestHandler<DeleteNonPlayerCommand, bool>
    {
        private INonPlayerService service;

        public DeleteNonPlayerCommandHandler(INonPlayerService service)
        {
            this.service = service;
        }

        public async Task<bool> Handle(DeleteNonPlayerCommand request, CancellationToken cancellationToken)
        {
            return await service.Delete(request.Id);
        }
    }
}
