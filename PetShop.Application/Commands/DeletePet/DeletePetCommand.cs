using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Application.Commands.DeletePet
{
    public class DeletePetCommand : IRequest<Unit>
    {
        public DeletePetCommand(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
