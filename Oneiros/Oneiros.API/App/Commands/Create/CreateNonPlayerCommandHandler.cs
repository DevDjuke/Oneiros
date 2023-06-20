using MediatR;
using Oneiros.API.Infrastructure.Services.Base;

namespace Oneiros.API.App.Commands.Create
{
    public class CreateNonPlayerCommandHandler : IRequestHandler<CreateNonPlayerCommand, bool>
    {
        private INonPlayerService service;

        public CreateNonPlayerCommandHandler(INonPlayerService service)
        {
            this.service = service;
        }

        public async Task<bool> Handle(CreateNonPlayerCommand request, CancellationToken cancellationToken)
        {
            return await service.Create(request.NonPlayer);
        }
    }
}
