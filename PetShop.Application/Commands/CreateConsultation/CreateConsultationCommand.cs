using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Application.Commands.CreateConsultation
{
    public class CreateConsultationCommand : IRequest<int>
    {
        public decimal TotalCost { get;  set; }
        public DateTime ConsultationDate { get;  set; }
        public int IdPet { get;  set; }
        public int IdClient { get;  set; }
        public int IdVet { get;  set; }
    }
}
