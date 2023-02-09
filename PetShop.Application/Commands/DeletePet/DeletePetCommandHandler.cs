using MediatR;
using PetShop.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PetShop.Application.Commands.DeletePet
{
    public class DeletePetCommandHandler : IRequestHandler<DeletePetCommand, Unit>
    {
        private readonly IPetRepository _petRepository;
        public DeletePetCommandHandler(IPetRepository petRepository)
        {
            _petRepository = petRepository;
        }
        public async Task<Unit> Handle(DeletePetCommand request, CancellationToken cancellationToken)
        {
            var pet = await _petRepository.GetByIdAsync(request.Id);

            pet.Inactive();

            await _petRepository.SaveChangesAsync();

            return Unit.Value;
        }
    }
}
