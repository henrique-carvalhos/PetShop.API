using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Application.Commands.CreateAddress
{
    public class CreateAddressCommand : IRequest<int>
    {
        public string Street { get;  set; }
        public int HouseNumber { get;  set; }
        public string District { get;  set; }
        public string City { get;  set; }
        public string State { get;  set; }
        public string ZipCode { get;  set; }
        public int IdClient { get;  set; }
    }
}
