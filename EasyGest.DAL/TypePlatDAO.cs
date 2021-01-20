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
    public class TypePlatDAO
    {
        private static List<TypePlat> typePlats;
        private const string FILE_NAME = @"typePlat.json";
        private readonly string dbFolder;
        private FileInfo file;
        private TypePlat typePlat;

        public TypePlatDAO(string dbFolder)
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
                    typePlats = JsonConvert.DeserializeObject<List<TypePlat>>(json);
                }
            }
            if (typePlats == null)
            {
                typePlats = new List<TypePlat>();
            }
        }

        public void Set(TypePlat oldTypePlat, TypePlat newTypePlat)
        {
            var oldIndex = typePlats.IndexOf(oldTypePlat);
            var newIndex = typePlats.IndexOf(newTypePlat);
            typePlats[oldIndex] = newTypePlat;
            Save();
        }

        public TypePlat Get()
        {
            return typePlat;
        }

        public void Add(TypePlat typePlat)
        {
            var index = typePlats.IndexOf(typePlat);
            typePlats.Add(typePlat);
            Save();
        }

        private void Save()
        {
            using (StreamWriter sw = new StreamWriter(file.FullName, false))
            {
                string json = JsonConvert.SerializeObject(typePlats);
                sw.WriteLine(json);
            }
        }

        public void Remove(TypePlat typePlat)
        {
            typePlats.Remove(typePlat); //base sur TypePlat.Equals redefini
            Save();
        }

        public IEnumerable<TypePlat> Find()
        {
            return new List<TypePlat>(typePlats);
        }

        public IEnumerable<TypePlat> Find(Func<TypePlat, bool> predicate)
        {
            return new List<TypePlat>(typePlats.Where(predicate).ToArray());
        }
    }
}
