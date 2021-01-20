using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyGest.BO
{
    public class TypePlat
    {
        private static int count = 0;
        public int Id { get; set; }
        public string NomTypePlat { get; set; }

        public TypePlat()
        {
            count++;
        }

        public TypePlat(string nomTypePlat)
        {
            Id = count;
            NomTypePlat = nomTypePlat;
        }

        public override string ToString()
        {
            return NomTypePlat;
        }
    }
}
