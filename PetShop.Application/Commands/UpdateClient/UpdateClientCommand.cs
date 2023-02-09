using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Application.Commands.UpdateClient
{
    public class UpdateClientCommand : IRequest<Unit>
    {
        public int IdClient { get;  set; }
        public string FullName { get;  set; }
        public DateTime BirthDate { get;  set; }
        public string Email { get;  set; }
        public string Cpf { get;  set; }
        public char Sex { get;  set; }
    }
}
