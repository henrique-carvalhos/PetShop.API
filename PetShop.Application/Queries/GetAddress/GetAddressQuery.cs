using MediatR;
using PetShop.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Application.Queries.GetAddress
{
    public class GetAddressQuery : IRequest<AddressViewModel>
    {
        public GetAddressQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
