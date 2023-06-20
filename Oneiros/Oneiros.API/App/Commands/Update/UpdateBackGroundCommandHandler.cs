using MediatR;
using Oneiros.API.Infrastructure.Services.Base;

namespace Oneiros.API.App.Commands.Update
{
    public class UpdateBackGroundCommandHandler : IRequestHandler<UpdateBackGroundCommand, bool>
    {
        private IBackGroundService service;

        public UpdateBackGroundCommandHandler(IBackGroundService service)
        {
            this.service = service;
        }

        public async Task<bool> Handle(UpdateBackGroundCommand request, CancellationToken cancellationToken)
        {
            return await service.Update(request.BackGround);
        }
    }
}
