using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Application.ViewModels
{
    public class ConsultationViewModel
    {
        public ConsultationViewModel(int idConsultation,decimal totalCost, DateTime consultationDate, string petsName, string clientName /*string vetName*/)
        {
            IdConsultation = idConsultation;
            TotalCost = totalCost;
            ConsultationDate = consultationDate;
            PetsName = petsName;
            ClientName = clientName;
            //VetName = vetName;
        }

        public int IdConsultation { get; private set; }
        public decimal TotalCost { get; private set; }
        public DateTime ConsultationDate { get; private set; }
        public string PetsName { get; private set; }
        public string ClientName { get; private set; }
        //public string VetName { get; private set; }
    }
}
