using MediatR;
using PetShop.Application.ViewModels;
using PetShop.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace PetShop.Application.Queries.GetAllPets
{
    public class GetAllPetsQueryHandler : IRequestHandler<GetAllPetsQuery, List<PetsViewModel>>
    {
        private readonly IPetRepository _petRepository;
        public GetAllPetsQueryHandler(IPetRepository petRepository)
        {
            _petRepository = petRepository;
        }

        public async Task<List<PetsViewModel>> Handle(GetAllPetsQuery request, CancellationToken cancellationToken)
        {
            var pets = await _petRepository.GetAllPetsAsync();

            var petsViewModel = pets
                .Select(p => new PetsViewModel(p.PetsName, p.Sex, p.BirthDate, p.Breed, p.CreatedAt, p.Active))
                .ToList();

            return petsViewModel;
        }
    }
}
