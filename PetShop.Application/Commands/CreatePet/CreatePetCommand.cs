using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Application.Commands.CreatePet
{
    public class CreatePetCommand : IRequest<int>
    {
        public string PetsName { get;  set; }
        public char Sex { get;  set; }
        public DateTime BirthDate { get;  set; }
        public string Breed { get;  set; }
        public int IdClient { get;  set; }
        public int IdUser { get;  set; }
    }
}
