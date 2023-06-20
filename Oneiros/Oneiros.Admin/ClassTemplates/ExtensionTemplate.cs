using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oneiros.Admin.ClassTemplates
{
    public static class ExtensionTemplate
    {
        public static string RepositoryTemplate(string files)
        {
            return $@"using Microsoft.Extensions.DependencyInjection;
using Oneiros.API.Repositories;
using Oneiros.API.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oneiros.API.Infrastructure.Extensions
{{
    public static class RepositoryExtension
    {{
        public static void ConfigureRepositories(this IServiceCollection services)
        {{
            {files}
        }}
    }}
}}";
        }

        public static string ServiceTemplate(string files)
        {
            return $@"
using Oneiros.API.Infrastructure.Services;
using Oneiros.API.Infrastructure.Services.Base;

namespace Oneiros.API.Infrastructure.Extensions
{{
    public static class ServiceExtension
    {{
        public static void ConfigureServices(this IServiceCollection services)
        {{
           {files}
        }}
    }}
}}";
        }
    }
}
