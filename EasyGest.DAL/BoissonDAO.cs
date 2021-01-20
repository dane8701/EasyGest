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
    public class BoissonDAO
    {
        private static List<Boisson> boissons;
        private const string FILE_NAME = @"boisson.json";
        private readonly string dbFolder;
        private FileInfo file;
        private Boisson boisson;

        public BoissonDAO(string dbFolder)
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
                    boissons = JsonConvert.DeserializeObject<List<Boisson>>(json);
                }
            }
            if (boissons == null)
            {
                boissons = new List<Boisson>();
            }
        }

        public void Set(Boisson oldBoisson, Boisson newBoisson)
        {
            var oldIndex = boissons.IndexOf(oldBoisson);
            var newIndex = boissons.IndexOf(newBoisson);
            boissons[oldIndex] = newBoisson;
            Save();
        }

        public Boisson Get()
        {
            return boisson;
        }

        public void Add(Boisson boisson)
        {
            var index = boissons.IndexOf(boisson);
            boissons.Add(boisson);
            Save();
        }

        private void Save()
        {
            using (StreamWriter sw = new StreamWriter(file.FullName, false))
            {
                string json = JsonConvert.SerializeObject(boissons);
                sw.WriteLine(json);
            }
        }

        public void Remove(Boisson product)
        {
            boissons.Remove(product); //base sur Boisson.Equals redefini
            Save();
        }

        public IEnumerable<Boisson> Find()
        {
            return new List<Boisson>(boissons);
        }

        public IEnumerable<Boisson> Find(Func<Boisson, bool> predicate)
        {
            return new List<Boisson>(boissons.Where(predicate).ToArray());
        }
    }
}
