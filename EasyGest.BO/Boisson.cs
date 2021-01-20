using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyGest.BO
{
    public class Boisson
    {
        private static int count = 0;
        public int Id { get; set; }
        public string NomBoisson { get; set; }
        public int PrixBoisson { get; set; }
        public byte[] Picture { get; set; }
        public TypeBoisson typeBoisson { get; set; }
        public int IdTypePlat { get; set; }

        public Boisson()
        {
            count++;
        }

        public Boisson(string nomBoisson, int prixBoisson, byte[] picture, int idTypePlat)
        {
            Id = count;
            NomBoisson = nomBoisson;
            PrixBoisson = prixBoisson;
            Picture = picture;
            IdTypePlat = idTypePlat;
        }

        public override string ToString()
        {
            return NomBoisson;
        }
    }
}
