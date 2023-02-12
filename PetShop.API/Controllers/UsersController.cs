using MediatR;
using Microsoft.AspNetCore.Mvc;
using PetShop.Application.Commands.CreateUser;
using PetShop.Application.Commands.DeleteUser;
using PetShop.Application.Commands.UpdateUser;
using PetShop.Application.Queries.GetAllUsers;
using PetShop.Application.Queries.GetUser;
using System.Threading.Tasks;

namespace PetShop.API.Controllers
{
    [Route("api/users")]
    public class UsersController : ControllerBase
    {
        private readonly IMediator _mediator;
        public UsersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var query = new GetUserQuery(id);

            var user = await _mediator.Send(query);

            return Ok(user);
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var getAllUsers = new GetAllUsersQuery();

            var users = await _mediator.Send(getAllUsers);

            return Ok(users);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateUserCommand command)
        {
            var id = await _mediator.Send(command);

            return CreatedAtAction(nameof(GetById), new { id = id }, command);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] UpdateUserCommand command)
        {
            await _mediator.Send(command);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var user = new DeleteUserCommand(id);

            await _mediator.Send(user);

            return NoContent();
        }

    }
}
