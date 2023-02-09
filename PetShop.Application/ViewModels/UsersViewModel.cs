using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Application.ViewModels
{
    public class UsersViewModel
    {
        public UsersViewModel(int idUser, string fullName, DateTime birthDate, string email, string cpf, char sex, DateTime createdAt, bool active)
        {
            IdUser = idUser;
            FullName = fullName;
            BirthDate = birthDate;
            Email = email;
            Cpf = cpf;
            Sex = sex;
            CreatedAt = createdAt;
            Active = active;
        }

        public int IdUser { get; private set; }
        public string FullName { get; private set; }
        public DateTime BirthDate { get; private set; }
        public string Email { get; private set; }
        public string Cpf { get; private set; }
        public char Sex { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public bool Active { get; private set; }
    }
}
