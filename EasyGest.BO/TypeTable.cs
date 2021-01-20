using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyGest.BO
{
    public class TypeTable
    {
        private static int count = 0;
        public int Id { get; set; }
        public string NomTypeTable { get; set; }

        public TypeTable()
        {
            count++;
        }

        public TypeTable(string nomTypeTable)
        {
            Id = count;
            NomTypeTable = nomTypeTable;
        }

        public override string ToString()
        {
            return NomTypeTable;
        }

        public int ToId()
        {
            return Id;
        }
    }
}