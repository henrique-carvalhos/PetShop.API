using MediatR;
using PetShop.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PetShop.Application.Commands.UpdateAddress
{
    public class UpdateAddressCommandHandler : IRequestHandler<UpdateAddressCommand, Unit>
    {
        private readonly IAddressRepository _addressRepository;
        public UpdateAddressCommandHandler(IAddressRepository addressRepository)
        {
            _addressRepository = addressRepository;
        }
        public async Task<Unit> Handle(UpdateAddressCommand request, CancellationToken cancellationToken)
        {
            var address = await _addressRepository.GetAddressById(request.IdAddress);

            address.Update(request.Street, request.HouseNumber, request.District, request.City, request.State, request.ZipCode);

            await _addressRepository.SavaChangesAsync();

            return Unit.Value;
        }
    }
}
