using MediatR;
using Microsoft.AspNetCore.Mvc;
using Oneiros.API.App.Players.Commands;
using Oneiros.Domain.Model;
using Oneiros.Data.DTO;

namespace Oneiros.API.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class PlayerController : Controller
    {
        private readonly IMediator mediator;

        public PlayerController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpPost("/add")]
        public async Task<Player> AddPlayer([FromBody] NewPlayerDTO newPlayer)
        {
            return await mediator.Send(new AddPlayerCommand() { NewPlayer = newPlayer });
        }
    }
}
