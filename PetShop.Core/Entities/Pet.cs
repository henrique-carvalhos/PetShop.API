using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Core.Entities
{
    public class Pet : BaseEntity
    {
        public Pet(string petsName, char sex, DateTime birthDate, string breed, int idClient, int idUser)
        {
            PetsName = petsName;
            Sex = sex;
            BirthDate = birthDate;
            Breed = breed;
            IdClient = idClient;
            IdUser = idUser;

            CreatedAt = DateTime.Now;
            Active = true;
        }

        public int IdPet { get; private set; }
        public string PetsName { get; private set; }
        public char Sex { get; private set; }
        public DateTime BirthDate { get; private set; }
        public string Breed { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public bool Active { get; private set; }
        public Client Client { get; private set; }
        public int IdClient { get; private set; }
        public User User { get; private set; }
        public int IdUser { get; private set; }

        public List<Consultation> Consultations { get; private set; }

        public void Update(string petsName, char sex, DateTime birthDate, string breed)
        {
            PetsName = petsName;
            Sex = sex;
            BirthDate = birthDate;
            Breed = breed;
        }

        public void Inactive()
        {
            if (Active == true)
            {
                Active = false;
            }
        }
    }
}
