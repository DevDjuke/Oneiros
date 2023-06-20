using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oneiros.Admin.ClassTemplates
{
    public static class APIControllerTemplate
    {
        public static string Template(string filename)
        {
            return 
$@"using MediatR;
using Microsoft.AspNetCore.Mvc;
using Oneiros.API.Controllers.Base;
using Oneiros.Data.DTO;

namespace Oneiros.API.Controllers
{{
    [ApiController]
    [Route(""[controller]"")]
    [Produces(""application/json"")]
    public class {filename}Controller : BaseController, ICrudController
    {{
        public {filename}Controller(IMediator mediator) : base(mediator) {{ }}

        [HttpGet(""all"")]
        public async Task<JsonResult> GetAll()
        {{
            throw new NotImplementedException();
        }}

        [HttpGet(""detail/{{id}}"")]
        public async Task<JsonResult> Get(int id)
        {{
            throw new NotImplementedException();
        }}

        [HttpDelete(""{{id}}"")]
        public async Task<IActionResult> Delete(int id)
        {{
            throw new NotImplementedException();
        }}

        [HttpPut(""{{id}}"")]
        public Task<IActionResult> Update()
        {{
            throw new NotImplementedException();
        }}

        [HttpPost]
        public Task<IActionResult> Create()
        {{
            throw new NotImplementedException();
        }}
    }}
}}";
        }
    }
}
