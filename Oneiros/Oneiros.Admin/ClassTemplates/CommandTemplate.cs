namespace Oneiros.Admin.ClassTemplates
{
    public static class CommandTemplate
    {
        public static string DeleteTemplate(string filename)
        {
            return @$"using MediatR;

namespace Oneiros.API.App.Commands.Delete
{{
    public class Delete{filename}Command : IRequest<bool>
    {{
        public int Id {{ get; set; }}
    }}
}}
";
        }

        public static string UpdateTemplate(string filename)
        {
            return @$"using MediatR;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Commands.Update
{{
    public class Update{filename}Command : IRequest<bool>
    {{
        public {filename}DTO {filename} {{ get; set; }}
    }}
}}";
        }

        public static string CreateTemplate(string filename)
        {
            return @$"using MediatR;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Commands.Create
{{
    public class Create{filename}Command : IRequest<bool>
    {{
        public {filename}DTO {filename} {{ get; set; }}
    }}
}}";
        }

        public static string DeleteHandlerTemplate(string filename)
        {
            return $@"using MediatR;
using Oneiros.API.Infrastructure.Services.Base;

namespace Oneiros.API.App.Commands.Delete
{{
    public class Delete{filename}CommandHandler : IRequestHandler<Delete{filename}Command, bool>
    {{
        private I{filename}Service service;

        public Delete{filename}CommandHandler(I{filename}Service service)
        {{
            this.service = service;
        }}

        public async Task<bool> Handle(Delete{filename}Command request, CancellationToken cancellationToken)
        {{
            return await service.Delete(request.Id);
        }}
    }}
}}
";
        }

        public static string UpdateHandlerTemplate(string filename)
        {
            return $@"using MediatR;
using Oneiros.API.Infrastructure.Services.Base;

namespace Oneiros.API.App.Commands.Update
{{
    public class Update{filename}CommandHandler : IRequestHandler<Update{filename}Command, bool>
    {{
        private I{filename}Service service;

        public Update{filename}CommandHandler(I{filename}Service service)
        {{
            this.service = service;
        }}

        public async Task<bool> Handle(Update{filename}Command request, CancellationToken cancellationToken)
        {{
            return await service.Update(request.{filename});
        }}
    }}
}}
";
        }

        public static string CreateHandlerTemplate(string filename)
        {
            return $@"using MediatR;
using Oneiros.API.Infrastructure.Services.Base;

namespace Oneiros.API.App.Commands.Create
{{
    public class Create{filename}CommandHandler : IRequestHandler<Create{filename}Command, bool>
    {{
        private I{filename}Service service;

        public Create{filename}CommandHandler(I{filename}Service service)
        {{
            this.service = service;
        }}

        public async Task<bool> Handle(Create{filename}Command request, CancellationToken cancellationToken)
        {{
            return await service.Create(request.{filename});
        }}
    }}
}}
";
        }
    }
}
