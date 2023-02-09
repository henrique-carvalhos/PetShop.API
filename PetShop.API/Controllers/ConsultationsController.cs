using MediatR;
using Microsoft.AspNetCore.Mvc;
using PetShop.Application.Queries.GetAllConsultations;
using PetShop.Application.Queries.GetConsultation;
using System.Threading.Tasks;

namespace PetShop.API.Controllers
{
    [Route("api/consultations")]
    public class ConsultationsController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ConsultationsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var query = new GetConsultationQuery(id);

            var consultation = await _mediator.Send(query);

            return Ok(consultation);
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var getAllConsultations = new GetAllConsultationsQuery();

            var consultations = await _mediator.Send(getAllConsultations);

            return Ok(consultations);
        }
    }
}
