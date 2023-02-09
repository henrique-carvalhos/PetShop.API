using MediatR;
using PetShop.Application.ViewModels;
using PetShop.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PetShop.Application.Queries.GetConsultation
{
    public class GetConsultationQueryHandler : IRequestHandler<GetConsultationQuery, ConsultationViewModel>
    {
        private readonly IConsultationRepository _consultationRepository;
        public GetConsultationQueryHandler(IConsultationRepository consultationRepository)
        {
            _consultationRepository = consultationRepository;
        }
        public async Task<ConsultationViewModel> Handle(GetConsultationQuery request, CancellationToken cancellationToken)
        {
            var consultation = await _consultationRepository.GetConsultationAsync(request.Id);

            var consultationViewModel = new ConsultationViewModel(
                consultation.IdConsultation, 
                consultation.TotalCost,
                consultation.ConsultationDate,
                consultation.Pet.PetsName, 
                consultation.Client.FullName);

            return consultationViewModel;
        }
    }
}
