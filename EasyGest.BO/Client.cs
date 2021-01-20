using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyGest.BO
{
    public class Client
    {
        private static int count = 0;
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public double Contact { get; set; }
        public string Email { get; set; }
        public string Adresse { get; set; }
        public int IdTable { get; set; }
        public Client()
        {
            count++;
        }

        public Client(string nom, string prenom, double contact, string email, string adresse, int idTable)
        {
            Id = count;
            Nom = nom;
            Prenom = prenom;
            Contact = contact;
            Email = email;
            Adresse = adresse;
            IdTable = idTable;
        }

        public override string ToString()
        {
            return "Nom : " + Nom + " Prenom : " + Prenom;
        }
    }
}
