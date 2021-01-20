using EasyGest.BO;
using EasyGest.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyGest.BLL
{
    public class TableBLO
    {
        TableDAO tableRepo;
        public TableBLO(string dbfolder)
        {
            tableRepo = new TableDAO(dbfolder);
        }

        public void Save(Table table)
        {
            if (table == null)
                throw new ArgumentNullException(nameof(table));
            var erros = validate(table);
            if (erros != null && erros.Count > 0)
                throw new TypingException(erros);
            tableRepo.Add(table);
        }
        public void DeleteTable(Table table)
        {
            tableRepo.Remove(table);
        }
        public IEnumerable<Table> GetBy(Func<Table, bool> predicate)
        {
            return tableRepo.Find(predicate);
        }
        public IEnumerable<Table> GetById(int id)
        {
            return tableRepo.Find(x => x.Id == id);
        }
        private List<KeyValuePair<string, string>> validate(Table table)
        {
            List<KeyValuePair<string, string>> erros = new List<KeyValuePair<string, string>>();
            
            return erros;
        }

        public IEnumerable<Table> GetAllTable()
        {
            return tableRepo.Find();
        }
        public void EditTable(Table oldTable, Table newTable)
        {
            tableRepo.Set(oldTable, newTable);
        }
    }
}
