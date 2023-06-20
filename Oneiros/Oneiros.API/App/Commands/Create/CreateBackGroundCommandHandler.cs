using MediatR;
using Oneiros.API.Infrastructure.Services.Base;

namespace Oneiros.API.App.Commands.Create
{
    public class CreateBackGroundCommandHandler : IRequestHandler<CreateBackGroundCommand, bool>
    {
        private IBackGroundService service;

        public CreateBackGroundCommandHandler(IBackGroundService service)
        {
            this.service = service;
        }

        public async Task<bool> Handle(CreateBackGroundCommand request, CancellationToken cancellationToken)
        {
            return await service.Create(request.BackGround);
        }
    }
}
