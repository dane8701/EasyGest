using EasyGest.BO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyGest.DAL
{
    public class TableDAO
    {
        private static List<Table> tables;
        private const string FILE_NAME = @"table.json";
        private readonly string dbFolder;
        private FileInfo file;
        private Table table;

        public TableDAO(string dbFolder)
        {
            this.dbFolder = dbFolder;
            file = new FileInfo(Path.Combine(this.dbFolder, FILE_NAME));
            if (!file.Directory.Exists)
            {
                file.Directory.Create();
            }
            if (!file.Exists)
            {
                file.Create().Close();
                file.Refresh();
            }
            if (file.Length > 0)
            {
                using (StreamReader sr = new StreamReader(file.FullName))
                {
                    string json = sr.ReadToEnd();
                    tables = JsonConvert.DeserializeObject<List<Table>>(json);
                }
            }
            if (tables == null)
            {
                tables = new List<Table>();
            }
        }

        public void Set(Table oldTable, Table newTable)
        {
            var oldIndex = tables.IndexOf(oldTable);
            var newIndex = tables.IndexOf(newTable);
            tables[oldIndex] = newTable;
            Save();
        }

        public Table Get()
        {
            return table;
        }

        public void Add(Table table)
        {
            var index = tables.IndexOf(table);
            tables.Add(table);
            Save();
        }

        private void Save()
        {
            using (StreamWriter sw = new StreamWriter(file.FullName, false))
            {
                string json = JsonConvert.SerializeObject(tables);
                sw.WriteLine(json);
            }
        }

        public void Remove(Table product)
        {
            tables.Remove(product); //base sur Table.Equals redefini
            Save();
        }

        public IEnumerable<Table> Find()
        {
            return new List<Table>(tables);
        }

        public IEnumerable<Table> Find(Func<Table, bool> predicate)
        {
            return new List<Table>(tables.Where(predicate).ToArray());
        }
    }
}