using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace PetShop.Core.Entities
{
    public class User : BaseEntity
    {
        public User(string fullName, DateTime birthDate, string email, string cpf, char sex)
        {
            FullName = fullName;
            BirthDate = birthDate;
            Email = email;
            Cpf = cpf;
            Sex = sex;

            CreatedAt = DateTime.Now;
            Active = true;
        }

        public int IdUser { get; private set; }
        public string FullName { get; private set; }
        public DateTime BirthDate { get; private set; }
        public string Email { get; private set; }
        public string Cpf { get; private set; }
        public char Sex { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public bool Active { get; private set; }
        public Address Address { get; private set; }//correto

        public List<Client> Clients { get; private set; }
        public List<Address> Addresses { get; private set; }
        public List<Pet> Pets { get; private set; }
        public List<Consultation> Consultations { get; private set; }
    }
}
