using MediatR;
using PetShop.Application.ViewModels;
using PetShop.Core.Repositories;
using System.Threading;
using System.Threading.Tasks;

namespace PetShop.Application.Queries.GetAddress
{
    public class GetAddressQueryHandler : IRequestHandler<GetAddressQuery, AddressViewModel>
    {
        private readonly IAddressRepository _addressRepository;
        public GetAddressQueryHandler(IAddressRepository addressRepository)
        {
            _addressRepository = addressRepository;
        }
        public async Task<AddressViewModel> Handle(GetAddressQuery request, CancellationToken cancellationToken)
        {
            var address = await _addressRepository.GetAddressById(request.Id);

            var addressViewModel = new AddressViewModel(
                address.IdAddress,
                address.Street,
                address.HouseNumber,
                address.District,
                address.City,
                address.State,
                address.ZipCode,
                address.Client.IdClient);

            return addressViewModel;
        }
    }
}
