using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyGest.BO
{
    public class Table
    {
        
        public int Id { get; set; }
        public int NombrePlace { get; set; }
        public TypeTable typeTable { get; set; }
        public int IdTypeTable { get; set; }

        public Table()
        {

        }

        public Table(int id, int nombrePlace, int idTypeTable)
        {
            Id = id;
            NombrePlace = nombrePlace;
            IdTypeTable = idTypeTable;
        }

        public override string ToString()
        {
            return "Table N°" + Id + " : " + NombrePlace + " places ";
        }
    }
}