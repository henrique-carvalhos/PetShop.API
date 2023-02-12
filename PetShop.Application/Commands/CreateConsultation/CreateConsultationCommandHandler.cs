using MediatR;
using PetShop.Core.Entities;
using PetShop.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PetShop.Application.Commands.CreateConsultation
{
    public class CreateConsultationCommandHandler : IRequestHandler<CreateConsultationCommand, int>
    {
        private readonly IConsultationRepository _conultationRepository;
        public CreateConsultationCommandHandler(IConsultationRepository conultationRepository)
        {
            _conultationRepository = conultationRepository;
        }

        public async Task<int> Handle(CreateConsultationCommand request, CancellationToken cancellationToken)
        {
            var consultation = new Consultation(request.TotalCost, request.IdPet, request.IdClient, request.IdVet);

            await _conultationRepository.AddAsync(consultation);

            await _conultationRepository.SaveChangesAsync();

            return consultation.IdConsultation;
        }
    }
}
