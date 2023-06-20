namespace Oneiros.Admin.ClassTemplates
{
    public static class QueryTemplate
    {
        public static string GetAllTemplate(string filename)
        {
            return @$"
using MediatR;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Queries.GetAll
{{
    public class GetAll{filename}sQuery : IRequest<IEnumerable<{filename}DTO>>
    {{
    }}
}}";
        }

        public static string GetIdTemplate(string filename)
        {
            return @$"
using MediatR;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Queries.GetById
{{
    public class Get{filename}ByIdQuery : IRequest<{filename}DTO>
    {{
        public int Id {{ get; set; }}
    }}
}}";
        }

        public static string GetAllHandlerTemplate(string filename)
        {
            return @$"
using MediatR;
using Oneiros.API.Infrastructure.Services.Base;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Queries.GetAll
{{
    public class GetAll{filename}sQueryHandler : IRequestHandler<GetAll{filename}sQuery, IEnumerable<{filename}DTO>>
    {{
        private I{filename}Service service;

        public GetAll{filename}sQueryHandler(I{filename}Service service)
        {{
            this.service = service;
        }}

        public async Task<IEnumerable<{filename}DTO>> Handle(GetAll{filename}sQuery request, CancellationToken cancellationToken)
        {{
            return (await service.GetAll()).ToList();
        }}
    }}
}}
";
        }

        public static string GetIdHandlerTemplate(string filename)
        {
            return @$"using MediatR;
using Oneiros.API.Infrastructure.Services.Base;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Queries.GetById
{{
    public class Get{filename}ByIdQueryHandler : IRequestHandler<Get{filename}ByIdQuery, {filename}DTO>
    {{
        private I{filename}Service service;

        public Get{filename}ByIdQueryHandler(I{filename}Service service)
        {{
            this.service = service;
        }}

        public async Task<{filename}DTO> Handle(Get{filename}ByIdQuery request, CancellationToken cancellationToken)
        {{
            return await service.GetById(request.Id);
        }}
    }}
}}
";
        }
    }
}
