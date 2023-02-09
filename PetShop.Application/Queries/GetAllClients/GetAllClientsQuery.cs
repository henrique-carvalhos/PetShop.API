using MediatR;
using PetShop.Application.ViewModels;
using System.Collections.Generic;

namespace PetShop.Application.Queries.GetAllClients
{
    public class GetAllClientsQuery : IRequest<List<ClientsViewModel>>
    {
    }
}
