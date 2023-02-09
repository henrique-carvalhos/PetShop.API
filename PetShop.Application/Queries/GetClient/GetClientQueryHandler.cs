using MediatR;
using PetShop.Application.ViewModels;
using PetShop.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PetShop.Application.Queries.GetClient
{
    public class GetClientQueryHandler : IRequestHandler<GetClientQuery, ClientViewModel>
    {
        private readonly IClientRepository _clientRepository;
        public GetClientQueryHandler(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }
        public async Task<ClientViewModel> Handle(GetClientQuery request, CancellationToken cancellationToken)
        {
            var client = await _clientRepository.GetClientByIdAsync(request.Id);

            var clientViewModel = new ClientViewModel(
                client.IdClient,
                client.FullName,
                client.BirthDate,
                client.Email,
                client.Cpf,
                client.Sex,
                client.CreatedAt,
                client.Active);

            return clientViewModel;
        }
    }
}
