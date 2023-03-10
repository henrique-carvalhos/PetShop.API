using MediatR;
using Microsoft.AspNetCore.Mvc;
using PetShop.Application.Commands.CreateAddress;
using PetShop.Application.Commands.UpdateAddress;
using PetShop.Application.Queries.GetAddress;
using PetShop.Application.Queries.GetAllAddress;
using System.Threading.Tasks;

namespace PetShop.API.Controllers
{
    [Route("api/address")]
    public class AddressesController : ControllerBase
    {
        private readonly IMediator _mediator;
        public AddressesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var query = new GetAddressQuery(id);

            var address = await _mediator.Send(query);

            return Ok(address);
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var getAllAddresses = new GetAllAddressesQuery();

            var addresses = await _mediator.Send(getAllAddresses);

            return Ok(addresses);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] UpdateAddressCommand command)
        {
            await _mediator.Send(command);

            return NoContent();
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateAddressCommand command)
        {
            var id = await _mediator.Send(command);

            return CreatedAtAction(nameof(GetById), new { id = id }, command);
        }
    }
}
