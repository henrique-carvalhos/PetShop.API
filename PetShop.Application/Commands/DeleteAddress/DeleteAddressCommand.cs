using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Application.Commands.DeleteAddress
{
    public class DeleteAddressCommand
    {
        public DeleteAddressCommand(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
