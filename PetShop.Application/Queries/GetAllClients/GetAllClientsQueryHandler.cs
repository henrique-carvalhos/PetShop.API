using MediatR;
using PetShop.Application.ViewModels;
using PetShop.Core.Repositories;
using PetShop.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PetShop.Application.Queries.GetAllClients
{
    public class GetAllClientsQueryHandler : IRequestHandler<GetAllClientsQuery, List<ClientsViewModel>>
    {
        private readonly IClientRepository _clientRepository;
        public GetAllClientsQueryHandler(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }
        public async Task<List<ClientsViewModel>> Handle(GetAllClientsQuery request, CancellationToken cancellationToken)
        {
            var clients = await _clientRepository.GetAllClientsAsync();

            var clientsViewModel = clients
                .Select(p => new ClientsViewModel(p.IdClient, p.FullName, p.BirthDate, p.Email, p.Cpf, p.Sex, p.Active))
                .ToList();

            return clientsViewModel;
        }
    }
}
