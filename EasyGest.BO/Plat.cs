using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyGest.BO
{
    public class Plat
    {
        private static int count = 0;
        public int Id { get; set; }
        public string NomPlat { get; set; }
        public int PrixPlat { get; set; }
        public byte[] Picture { get; set; }
        public TypePlat typePlat { get; set; }
        public int IdTypePlat { get; set; }

        public Plat()
        {
            count++;
        }

        public Plat(string nomPlat, int prixPlat, byte[] picture, int idTypePlat)
        {
            Id = count;
            NomPlat = nomPlat;
            PrixPlat = prixPlat;
            Picture = picture;
            IdTypePlat = idTypePlat;
        }

        public override string ToString()
        {
            return NomPlat;
        }
    }
}
