<<<<<<< HEAD
﻿using MediatR;
using PetShop.Application.ViewModels;
using PetShop.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
>>>>>>> a87d793ea8b2780862709b87271a4f1d9d25b8cc
using System.Threading.Tasks;

namespace PetShop.Application.Queries.GetAddress
{
<<<<<<< HEAD
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
=======
    public class GetAddressQueryHandler
    {
>>>>>>> a87d793ea8b2780862709b87271a4f1d9d25b8cc
    }
}
