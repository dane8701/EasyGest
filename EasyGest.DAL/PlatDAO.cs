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
    public class PlatDAO
    {
        private static List<Plat> plats;
        private const string FILE_NAME = @"plat.json";
        private readonly string dbFolder;
        private FileInfo file;
        private Plat plat;

        public PlatDAO(string dbFolder)
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
                    plats = JsonConvert.DeserializeObject<List<Plat>>(json);
                }
            }
            if (plats == null)
            {
                plats = new List<Plat>();
            }
        }

        public void Set(Plat oldPlat, Plat newPlat)
        {
            var oldIndex = plats.IndexOf(oldPlat);
            var newIndex = plats.IndexOf(newPlat);
            plats[oldIndex] = newPlat;
            Save();
        }

        public Plat Get()
        {
            return plat;
        }

        public void Add(Plat plat)
        {
            var index = plats.IndexOf(plat);
            plats.Add(plat);
            Save();
        }

        private void Save()
        {
            using (StreamWriter sw = new StreamWriter(file.FullName, false))
            {
                string json = JsonConvert.SerializeObject(plats);
                sw.WriteLine(json);
            }
        }

        public void Remove(Plat product)
        {
            plats.Remove(product); //base sur Plat.Equals redefini
            Save();
        }

        public IEnumerable<Plat> Find()
        {
            return new List<Plat>(plats);
        }

        public IEnumerable<Plat> Find(Func<Plat, bool> predicate)
        {
            return new List<Plat>(plats.Where(predicate).ToArray());
        }
    }
}
