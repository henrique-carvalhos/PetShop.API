using MediatR;
using PetShop.Application.ViewModels;
using PetShop.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PetShop.Application.Queries.GetAllConsultations
{
    public class GetAllConsultationsQueryHandler : IRequestHandler<GetAllConsultationsQuery, List<ConsultationsViewModel>>
    {
        private readonly IConsultationRepository _consultationRepository;
        public GetAllConsultationsQueryHandler(IConsultationRepository consultationRepository)
        {
            _consultationRepository = consultationRepository;
        }

        public async Task<List<ConsultationsViewModel>> Handle(GetAllConsultationsQuery request, CancellationToken cancellationToken)
        {
            var consultations = await _consultationRepository.GetAllConsultationAsync();

            var consultationsViewModel = consultations
                .Select(p => new ConsultationsViewModel(p.IdConsultation, p.TotalCost, p.ConsultationDate, p.Pet.PetsName, p.Client.FullName))
                .ToList();

            return consultationsViewModel;
        }
    }
}
