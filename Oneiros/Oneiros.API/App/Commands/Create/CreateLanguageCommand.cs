using MediatR;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Commands.Create
{
    public class CreateLanguageCommand : IRequest<bool>
    {
        public LanguageDTO Language { get; set; }
    }
}