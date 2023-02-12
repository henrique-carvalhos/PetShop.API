using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Application.Commands.UpdateAddress
{
    public class UpdateAddressCommand : IRequest<Unit>
    {
        public int IdAddress { get;  set; }
        public string Street { get;  set; }
        public int HouseNumber { get;  set; }
        public string District { get;  set; }
        public string City { get;  set; }
        public string State { get;  set; }
        public string ZipCode { get;  set; }
    }
}
