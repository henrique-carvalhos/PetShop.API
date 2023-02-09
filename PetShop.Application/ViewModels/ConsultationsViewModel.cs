using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Application.ViewModels
{
    public class ConsultationsViewModel
    {
        public ConsultationsViewModel(int idConsultation, decimal totalCost, DateTime consultationDate, string petsName, string clientName)
        {
            IdConsultation = idConsultation;
            TotalCost = totalCost;
            ConsultationDate = consultationDate;
            PetsName = petsName;
            ClientName = clientName;
        }

        public int IdConsultation { get; private set; }
        public decimal TotalCost { get; private set; }
        public DateTime ConsultationDate { get; private set; }
        public string PetsName { get; private set; }
        public string ClientName { get; private set; }
    }
}
