using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Application.Commands.CreateClient
{
    public class CreateClientCommand : IRequest<int>
    {
        public string FullName { get;  set; }
        public DateTime BirthDate { get;  set; }
        public string Email { get;  set; }
        public string Cpf { get;  set; }
        public char Sex { get;  set; }
        public int IdUser { get;  set; }
    }
}
