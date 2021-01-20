using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyGest.BO
{
    public class TypeBoisson
    {
        private static int count = 0;
        public int Id { get; set; }
        public string NomTypeBoisson { get; set; }

        public TypeBoisson()
        {
            count++;
        }

        public TypeBoisson(string nomTypeBoisson)
        {
            Id = count;
            NomTypeBoisson = nomTypeBoisson;
        }

        public override string ToString()
        {
            return NomTypeBoisson;
        }
    }
}
