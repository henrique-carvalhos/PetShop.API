using MediatR;
using PetShop.Application.ViewModels;
using System.Collections.Generic;

namespace PetShop.Application.Queries.GetAllPets
{
    public class GetAllPetsQuery : IRequest<List<PetsViewModel>>
    {
    }
}
