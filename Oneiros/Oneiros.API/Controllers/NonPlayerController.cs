using MediatR;
using Microsoft.AspNetCore.Mvc;
using Oneiros.API.App.Queries.GetAll;
using Oneiros.API.App.Queries.GetById;
using Oneiros.API.Controllers.Base;
using Oneiros.Data.DTO;
using Oneiros.Data.DTO.Derived;
using Oneiros.Domain.Model.CharacterModel.NonPlayer;

namespace Oneiros.API.Controllers
{
    [ApiController]
    [Route("npc")]
    [Produces("application/json")]
    public class NonPlayerControllerController : BaseController, ICrudController
    {
        public NonPlayerControllerController(IMediator mediator) : base(mediator) { }

        [HttpGet("all")]
        public async Task<JsonResult> GetAll()
        {
            throw new NotImplementedException();
        }

        [HttpGet("list")]
        public async Task<JsonResult> GetSimplifiedList()
        {
            List<NonPlayerDTO> npcs = (await mediator.Send(new GetAllNonPlayersQuery())).ToList();
            List<NPCSimpleDTO> result = new List<NPCSimpleDTO>();

            foreach(var n in npcs)
            {
                BuildDTO npcBuild = (await mediator.Send(new GetBuildByIdQuery() { Id = n.Builds[0].BuildId }));
                ClasseDTO npcClass = (await mediator.Send(new GetClasseByIdQuery() { Id = npcBuild.Preset.BaseClass.Id }));

                result.Add(new NPCSimpleDTO()
                {
                    Name = n.Name,
                    Race = n.Race.Name,
                    Id = n.Id,
                    Class = npcBuild.Preset.Name,
                    BaseClass = npcClass.Name 
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