using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Application.Commands.UpdateConsultation
{
    public class UpdateConsultationCommand : IRequest<Unit>
    {
        public int IdConsultation { get; set; }
        public decimal TotalCost { get; set; }
    }
}
