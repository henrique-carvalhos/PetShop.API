using MediatR;
using PetShop.Application.ViewModels;

namespace PetShop.Application.Queries.GetPet
{
    public class GetPetQuery : IRequest<PetViewModel>
    {
        public GetPetQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
