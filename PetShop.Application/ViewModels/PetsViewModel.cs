using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Application.ViewModels
{
    public class PetsViewModel
    {
        public PetsViewModel(string petsName, char sex, DateTime birthDate, string breed, DateTime createdAt, bool active)
        {
            PetsName = petsName;
            Sex = sex;
            BirthDate = birthDate;
            Breed = breed;
            CreatedAt = createdAt;
            Active = active;
        }

        public string PetsName { get; private set; }
        public char Sex { get; private set; }
        public DateTime BirthDate { get; private set; }
        public string Breed { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public bool Active { get; private set; }
    }
}
