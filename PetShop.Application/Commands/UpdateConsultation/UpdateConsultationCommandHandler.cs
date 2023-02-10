using MediatR;
using PetShop.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PetShop.Application.Commands.UpdateConsultation
{
    public class UpdateConsultationCommandHandler : IRequestHandler<UpdateConsultationCommand, Unit>
    {
        private readonly IConsultationRepository _consultationRepository;
        public UpdateConsultationCommandHandler(IConsultationRepository consultationRepository)
        {
            _consultationRepository = consultationRepository;
        }
        public async Task<Unit> Handle(UpdateConsultationCommand request, CancellationToken cancellationToken)
        {
            var consultation = await _consultationRepository.GetConsultationByIdAsync(request.IdConsultation);

            consultation.Update(request.TotalCost);

            await _consultationRepository.SaveChangesAsync();

            return Unit.Value;
        }
    }
}
