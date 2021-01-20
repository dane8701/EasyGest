using EasyGest.BO;
using EasyGest.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EasyGest.BLL
{
    public class ClientBLO
    {
        private readonly Repository<Client> repository;
        private ClientDAO clientRepo;

        public ClientBLO(string dbfolder)
        {
            clientRepo = new ClientDAO(dbfolder);
        }
        public void Save(Client client)
        {
            if (client == null)
                throw new ArgumentNullException(nameof(client));
            var erros = validate(client);
            if (erros != null && erros.Count > 0)
                throw new TypingException(erros);
            clientRepo.Add(client);
        }
        public void DeleteClient(Client client)
        {
            clientRepo.Remove(client);
        }
        public IEnumerable<Client> GetBy(Func<Client, bool> predicate)
        {
            return clientRepo.Find(predicate);
        }
        public IEnumerable<Client> GetById(int id)
        {
            return clientRepo.Find(x => x.Id == id);
        }
        private List<KeyValuePair<string, string>> validate(Client client)
        {
            List<KeyValuePair<string, string>> erros = new List<KeyValuePair<string, string>>();

            return erros;
        }

        public IEnumerable<Client> GetAllClient()
        {
            return clientRepo.Find();
        }
        public void EditClient(Client oldClient, Client newClient)
        {
            clientRepo.Set(oldClient, newClient);
        }
        
    }
}
