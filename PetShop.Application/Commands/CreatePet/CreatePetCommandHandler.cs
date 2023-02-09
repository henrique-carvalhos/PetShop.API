using MediatR;
using PetShop.Core.Entities;
using PetShop.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PetShop.Application.Commands.CreatePet
{
    public class CreatePetCommandHandler : IRequestHandler<CreatePetCommand, int>
    {
        private readonly IPetRepository _petRepository;
        public CreatePetCommandHandler(IPetRepository petRepository)
        {
            _petRepository = petRepository;
        }
        public async Task<int> Handle(CreatePetCommand request, CancellationToken cancellationToken)
        {
            var pet = new Pet(request.PetsName, request.Sex, request.BirthDate, request.Breed, request.IdClient, request.IdUser);

            await _petRepository.AddAsync(pet);

            return pet.IdPet;
        }
    }
}
