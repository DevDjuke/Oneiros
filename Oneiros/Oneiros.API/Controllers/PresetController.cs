using MediatR;
using Microsoft.AspNetCore.Mvc;
using Oneiros.API.App.Queries.GetAll;
using Oneiros.API.App.Queries.GetById;
using Oneiros.API.Controllers.Base;
using Oneiros.Data.DTO;
using Oneiros.Data.DTO.Derived;

namespace Oneiros.API.Controllers
{
    [ApiController]
    [Route("preset")]
    [Produces("application/json")]
    public class PresetControllerController : BaseController, ICrudController
    {
        public PresetControllerController(IMediator mediator) : base(mediator) { }

        [HttpGet("all")]
        public async Task<JsonResult> GetAll()
        {
            throw new NotImplementedException();
        }

        [HttpGet("list")]
        public async Task<JsonResult> GetSimplifiedList()
        {
            List<PresetDTO> presets = (await mediator.Send(new GetAllPresetsQuery())).ToList();
            List<PresetSimpleDTO> result = new List<PresetSimpleDTO>();

            foreach (var n in presets)
            {
                result.Add(new PresetSimpleDTO()
                {
                    Name = n.Name,
                    Id = n.Id,
                    BaseClass = n.BaseClass.Name
                });
            }

            return new JsonResult(result);
        }

        [HttpGet("detail/{id}")]
        public async Task<JsonResult> Get(int id)
        {
            throw new NotImplementedException();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            throw new NotImplementedException();
        }

        [HttpPut("{id}")]
        public Task<IActionResult> Update()
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public Task<IActionResult> Create()
        {
            throw new NotImplementedException();
        }
    }
}