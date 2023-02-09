using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Application.Commands.UpdatePet
{
    public class UpdatePetCommand : IRequest<Unit>
    {
        public int IdPet { get; set; }
        public string PetsName { get; set; }
        public char Sex { get; set; }
        public DateTime BirthDate { get; set; }
        public string Breed { get; set; }
    }
}
