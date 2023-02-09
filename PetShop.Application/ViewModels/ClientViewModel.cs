using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Application.ViewModels
{
    public class ClientViewModel
    {
        public ClientViewModel(int idClient, string fullName, DateTime birthDate, string email, string cpf, char sex, DateTime createdAt, bool active)
        {
            IdClient = idClient;
            FullName = fullName;
            BirthDate = birthDate;
            Email = email;
            Cpf = cpf;
            Sex = sex;
            CreatedAt = createdAt;
            Active = active;
        }

        public int IdClient { get; private set; }
        public string FullName { get; private set; }
        public DateTime BirthDate { get; private set; }
        public string Email { get; private set; }
        public string Cpf { get; private set; }
        public char Sex { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public bool Active { get; private set; }
    }
}
