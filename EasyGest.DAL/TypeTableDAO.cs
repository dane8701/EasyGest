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
    public class TypeTableDAO
    {
        private static List<TypeTable> typeTables;
        private const string FILE_NAME = @"typeTable.json";
        private readonly string dbFolder;
        private FileInfo file;
        private TypeTable typeTable;

        public TypeTableDAO(string dbFolder)
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
                    typeTables = JsonConvert.DeserializeObject<List<TypeTable>>(json);
                }
            }
            if (typeTables == null)
            {
                typeTables = new List<TypeTable>();
            }
        }

        public void Set(TypeTable oldTypeTable, TypeTable newTypeTable)
        {
            var oldIndex = typeTables.IndexOf(oldTypeTable);
            var newIndex = typeTables.IndexOf(newTypeTable);
            typeTables[oldIndex] = newTypeTable;
            Save();
        }

        public TypeTable Get()
        {
            return typeTable;
        }

        public void Add(TypeTable typeTable)
        {
            var index = typeTables.IndexOf(typeTable);
            typeTables.Add(typeTable);
            Save();
        }

        private void Save()
        {
            using (StreamWriter sw = new StreamWriter(file.FullName, false))
            {
                string json = JsonConvert.SerializeObject(typeTables);
                sw.WriteLine(json);
            }
        }

        public void Remove(TypeTable product)
        {
            typeTables.Remove(product); //base sur TypeTable.Equals redefini
            Save();
        }

        public IEnumerable<TypeTable> Find()
        {
            return new List<TypeTable>(typeTables);
        }

        public IEnumerable<TypeTable> Find(Func<TypeTable, bool> predicate)
        {
            return new List<TypeTable>(typeTables.Where(predicate).ToArray());
        }
    }
}