using MediatR;
using PetShop.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Application.Queries.GetConsultation
{
    public class GetConsultationQuery : IRequest<ConsultationViewModel>
    {
        public GetConsultationQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
