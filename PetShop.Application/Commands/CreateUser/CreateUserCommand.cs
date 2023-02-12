using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Application.Commands.CreateUser
{
    public class CreateUserCommand : IRequest<int>
    {
        public string FullName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public char Sex { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool Active { get; set; }
    }
}
