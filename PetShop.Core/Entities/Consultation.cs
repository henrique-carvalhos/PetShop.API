using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Core.Entities
{
    public class Consultation : BaseEntity
    {
        public Consultation(decimal totalCost, int idPet, int idClient, int idVet)
        {
            TotalCost = totalCost;
            IdPet = idPet;
            IdClient = idClient;
            IdVet = idVet;

            ConsultationDate = DateTime.Now;
        }

        public int IdConsultation { get; private set; }
        public decimal TotalCost { get; private set; }
        public DateTime ConsultationDate { get; private set; }
        public Pet Pet { get; private set; }//correto
        public int IdPet { get; private set; }//correto
        public Client Client { get; private set; }
        public int IdClient { get; private set; }
        public User Vet { get; private set; }//correto
        public int IdVet { get; private set; }//correto

        public void Update(decimal totalCost)
        {
            TotalCost = totalCost;
        }
    }
}
