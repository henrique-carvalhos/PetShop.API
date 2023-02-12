using MediatR;
using PetShop.Application.ViewModels;
using PetShop.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PetShop.Application.Queries.GetAllAddress
{
    public class GetAllAddressesQueryHandler : IRequestHandler<GetAllAddressesQuery, List<AddressesViewModel>>
    {
        private readonly IAddressRepository _addressRepository;
        public GetAllAddressesQueryHandler(IAddressRepository addressRepository)
        {
            _addressRepository = addressRepository;
        }
        public async Task<List<AddressesViewModel>> Handle(GetAllAddressesQuery request, CancellationToken cancellationToken)
        {
            var addresses = await _addressRepository.GetAllAddresses();

            var addressesViewModel = addresses
                .Select(p => new AddressesViewModel(
                    p.IdAddress,
                    p.Street, 
                    p.HouseNumber,
                    p.District,
                    p.City,
                    p.State,
                    p.ZipCode,
                    p.Client.IdClient))
                .ToList();

            return addressesViewModel;
        }
    }
}
