using MediatR;
using Oneiros.API.Infrastructure.Services.Base;

namespace Oneiros.API.App.Commands.Create
{
    public class CreatePresetCommandHandler : IRequestHandler<CreatePresetCommand, bool>
    {
        private IPresetService service;

        public CreatePresetCommandHandler(IPresetService service)
        {
            this.service = service;
        }

        public async Task<bool> Handle(CreatePresetCommand request, CancellationToken cancellationToken)
        {
            return await service.Create(request.Preset);
        }
    }
}
