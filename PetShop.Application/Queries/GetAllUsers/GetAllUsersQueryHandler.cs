using MediatR;
using PetShop.Application.ViewModels;
using PetShop.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PetShop.Application.Queries.GetAllUsers
{
    public class GetAllUsersQueryHandler : IRequestHandler<GetAllUsersQuery, List<UsersViewModel>>
    {
        private readonly IUserRepository _userRepository;
        public GetAllUsersQueryHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<List<UsersViewModel>> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
        {
            var users = await _userRepository.GetAllUsersAsync();

            var usersViewModel = users
                .Select(p => new UsersViewModel(p.IdUser, p.FullName, p.BirthDate, p.Email, p.Cpf, p.Sex, p.CreatedAt, p.Active))
                .ToList();

            return usersViewModel;
        }
    }
}
