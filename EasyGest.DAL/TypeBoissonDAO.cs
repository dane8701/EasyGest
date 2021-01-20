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
    public class TypeBoissonDAO
    {
        private static List<TypeBoisson> typeBoissons;
        private const string FILE_NAME = @"typeBoisson.json";
        private readonly string dbFolder;
        private FileInfo file;
        private TypeBoisson typeBoisson;

        public TypeBoissonDAO(string dbFolder)
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
                    typeBoissons = JsonConvert.DeserializeObject<List<TypeBoisson>>(json);
                }
            }
            if (typeBoissons == null)
            {
                typeBoissons = new List<TypeBoisson>();
            }
        }

        public void Set(TypeBoisson oldTypeBoisson, TypeBoisson newTypeBoisson)
        {
            var oldIndex = typeBoissons.IndexOf(oldTypeBoisson);
            var newIndex = typeBoissons.IndexOf(newTypeBoisson);
            typeBoissons[oldIndex] = newTypeBoisson;
            Save();
        }

        public TypeBoisson Get()
        {
            return typeBoisson;
        }

        public void Add(TypeBoisson typeBoisson)
        {
            var index = typeBoissons.IndexOf(typeBoisson);
            typeBoissons.Add(typeBoisson);
            Save();
        }

        private void Save()
        {
            using (StreamWriter sw = new StreamWriter(file.FullName, false))
            {
                string json = JsonConvert.SerializeObject(typeBoissons);
                sw.WriteLine(json);
            }
        }

        public void Remove(TypeBoisson product)
        {
            typeBoissons.Remove(product); //base sur TypeBoisson.Equals redefini
            Save();
        }

        public IEnumerable<TypeBoisson> Find()
        {
            return new List<TypeBoisson>(typeBoissons);
        }

        public IEnumerable<TypeBoisson> Find(Func<TypeBoisson, bool> predicate)
        {
            return new List<TypeBoisson>(typeBoissons.Where(predicate).ToArray());
        }
    }
}
