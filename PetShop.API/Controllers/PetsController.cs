using MediatR;
using Microsoft.AspNetCore.Mvc;
using PetShop.Application.Commands.CreatePet;
using PetShop.Application.Commands.DeletePet;
using PetShop.Application.Commands.UpdatePet;
using PetShop.Application.Queries.GetAllPets;
using PetShop.Application.Queries.GetPet;
using PetShop.Application.Queries.GetUser;
using System.Threading.Tasks;

namespace PetShop.API.Controllers
{
    [Route("api/pets")]
    public class PetsController : ControllerBase
    {
        private readonly IMediator _mediator;
        public PetsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var query = new GetPetQuery(id);

            var pet = await _mediator.Send(query);

            return Ok(pet);
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var getAllPets = new GetAllPetsQuery();

            var pets = await _mediator.Send(getAllPets);

            return Ok(pets);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] UpdatePetCommand command)
        {
            await _mediator.Send(command);

            return NoContent();
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreatePetCommand command)
        {
            var id = await _mediator.Send(command);

            return CreatedAtAction(nameof(GetById), new { id = id }, command);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var command = new DeletePetCommand(id);

            await _mediator.Send(command);

            return NoContent();
        }

    }
}
