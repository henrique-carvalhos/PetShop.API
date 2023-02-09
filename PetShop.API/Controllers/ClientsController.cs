using MediatR;
using Microsoft.AspNetCore.Mvc;
using PetShop.Application.Commands.CreateClient;
using PetShop.Application.Commands.DeleteClient;
using PetShop.Application.Commands.UpdateClient;
using PetShop.Application.Queries.GetAllClients;
using PetShop.Application.Queries.GetClient;
using System.Threading.Tasks;

namespace PetShop.API.Controllers
{
    [Route("api/clients")]
    public class ClientsController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ClientsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var query = new GetClientQuery(id);

            var client = await _mediator.Send(query); 

            return Ok(client);
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var getAllClients = new GetAllClientsQuery();

            var clients = await _mediator.Send(getAllClients);

            return Ok(clients);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] UpdateClientCommand command)
        {
            await _mediator.Send(command);

            return NoContent();
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateClientCommand command)
        {
            var id = await _mediator.Send(command);

            return CreatedAtAction(nameof(GetById), new {id = id}, command);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var command = new DeleteClientCommand(id);

            await _mediator.Send(command);

            return NoContent();
        }
    }
}
