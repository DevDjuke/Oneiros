using MediatR;
using Oneiros.API.Infrastructure.Services.Base;

namespace Oneiros.API.App.Commands.Update
{
    public class UpdateNonPlayerCommandHandler : IRequestHandler<UpdateNonPlayerCommand, bool>
    {
        private INonPlayerService service;

        public UpdateNonPlayerCommandHandler(INonPlayerService service)
        {
            this.service = service;
        }

        public async Task<bool> Handle(UpdateNonPlayerCommand request, CancellationToken cancellationToken)
        {
            return await service.Update(request.NonPlayer);
        }
    }
}
