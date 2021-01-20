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
    public class ClientDAO
    {
        private static List<Client> clients;
        private const string FILE_NAME = @"client.json";
        private readonly string dbFolder;
        private FileInfo file;
        private Client client;

        public ClientDAO(string dbFolder)
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
                    clients = JsonConvert.DeserializeObject<List<Client>>(json);
                }
            }
            if (clients == null)
            {
                clients = new List<Client>();
            }
        }

        public void Set(Client oldClient, Client newClient)
        {
            var oldIndex = clients.IndexOf(oldClient);
            var newIndex = clients.IndexOf(newClient);
            clients[oldIndex] = newClient;
            Save();
        }

        public Client Get()
        {
            return client;
        }

        public void Add(Client client)
        {
            var index = clients.IndexOf(client);
            clients.Add(client);
            Save();
        }

        private void Save()
        {
            using (StreamWriter sw = new StreamWriter(file.FullName, false))
            {
                string json = JsonConvert.SerializeObject(clients);
                sw.WriteLine(json);
            }
        }

        public void Remove(Client product)
        {
            clients.Remove(product); //base sur Client.Equals redefini
            Save();
        }

        public IEnumerable<Client> Find()
        {
            return new List<Client>(clients);
        }

        public IEnumerable<Client> Find(Func<Client, bool> predicate)
        {
            return new List<Client>(clients.Where(predicate).ToArray());
        }
    }
}
