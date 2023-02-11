using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Application.ViewModels
{
    public class AddressViewModel
    {
        public AddressViewModel(int idAddress, string street, int houseNumber, string district, string city, string state, string zipCode, int idClient)
        {
            IdAddress = idAddress;
            Street = street;
            HouseNumber = houseNumber;
            District = district;
            City = city;
            State = state;
            ZipCode = zipCode;
            IdClient = idClient;
        }

        public int IdAddress { get; private set; }
        public string Street { get; private set; }
        public int HouseNumber { get; private set; }
        public string District { get; private set; }
        public string City { get; private set; }
        public string State { get; private set; }
        public string ZipCode { get; private set; }
        public int IdClient { get; private set; }
    }
}
