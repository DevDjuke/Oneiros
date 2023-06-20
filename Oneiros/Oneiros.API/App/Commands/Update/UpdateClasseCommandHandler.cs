using MediatR;
using Oneiros.API.Infrastructure.Services.Base;

namespace Oneiros.API.App.Commands.Update
{
    public class UpdateClasseCommandHandler : IRequestHandler<UpdateClasseCommand, bool>
    {
        private IClasseService service;

        public UpdateClasseCommandHandler(IClasseService service)
        {
            this.service = service;
        }

        public async Task<bool> Handle(UpdateClasseCommand request, CancellationToken cancellationToken)
        {
            return await service.Update(request.Classe);
        }
    }
}
