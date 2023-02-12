using MediatR;
using PetShop.Core.Entities;
using PetShop.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PetShop.Application.Commands.CreateAddress
{
    public class CreateAddressCommandHandler : IRequestHandler<CreateAddressCommand, int>
    {
        private readonly IAddressRepository _addressRepository;
        public CreateAddressCommandHandler(IAddressRepository addressRepository)
        {
            _addressRepository = addressRepository;
        }
        public async Task<int> Handle(CreateAddressCommand request, CancellationToken cancellationToken)
        {
            var address = new Address(request.Street, request.HouseNumber, request.District, request.City, request.State, request.ZipCode, request.IdClient);

            await _addressRepository.AddAsync(address);

            return address.IdAddress;
        }
    }
}
