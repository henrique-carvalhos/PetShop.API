using MediatR;
using PetShop.Application.ViewModels;

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
