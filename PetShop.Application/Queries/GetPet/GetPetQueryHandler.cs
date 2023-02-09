using MediatR;
using PetShop.Application.ViewModels;
using PetShop.Core.Repositories;
using System.Threading;
using System.Threading.Tasks;

namespace PetShop.Application.Queries.GetPet
{
    public class GetPetQueryHandler : IRequestHandler<GetPetQuery, PetViewModel>
    {
        private readonly IPetRepository _petRepository;
        public GetPetQueryHandler(IPetRepository petRepository)
        {
            _petRepository = petRepository;
        }

        public async Task<PetViewModel> Handle(GetPetQuery request, CancellationToken cancellationToken)
        {
            var pet = await _petRepository.GetByIdAsync(request.Id);

            return new PetViewModel(pet.PetsName, pet.Sex, pet.BirthDate, pet.Breed, pet.CreatedAt, pet.Active);
        }
    }
}
