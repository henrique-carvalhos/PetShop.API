using MediatR;
using PetShop.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Application.Queries.GetAllConsultations
{
    public class GetAllConsultationsQuery : IRequest<List<ConsultationsViewModel>>
    {
    }
}
