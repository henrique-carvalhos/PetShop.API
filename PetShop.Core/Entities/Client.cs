using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Core.Entities
{
    public class Client :BaseEntity
    {
        public Client(string fullName, DateTime birthDate, string email, string cpf, char sex, int idUser)
        {
            FullName = fullName;
            BirthDate = birthDate;
            Email = email;
            Cpf = cpf;
            Sex = sex;
            IdUser = idUser;

            CreatedAt = DateTime.Now;
            Active = true;
        }

        public int IdClient { get; private set; }
        public string FullName { get; private set; }
        public DateTime BirthDate { get; private set; }
        public string Email { get; private set; }
        public string Cpf { get; private set; }
        public char Sex { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public bool Active { get; private set; }
        public int IdUser { get; private set; }
        public User User { get; private set; }

        public List<Pet> Pets { get; private set; }
        public List<Address> Addresses { get; private set; }
        public List<Consultation> Consultations { get; private set; }

        public void Update(string fullName, DateTime birthDate, string email, string cpf, char sex)
        {
            FullName = fullName;
            BirthDate = birthDate;
            Email = email;
            Cpf = cpf;
            Sex = sex;
        }

        public void Inactive()
        {
            if(Active == true)
            {
                Active = false;
            } 
        }
    }
}
