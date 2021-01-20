using EasyGest.BO;
using EasyGest.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyGest.BLL
{
    public class BoissonBLO
    {
        BoissonDAO boissonRepo;
        public BoissonBLO(string dbfolder)
        {
            boissonRepo = new BoissonDAO(dbfolder);
        }

        public void Save(Boisson boisson)
        {
            if (boisson == null)
                throw new ArgumentNullException(nameof(boisson));
            var erros = validate(boisson);
            if (erros != null && erros.Count > 0)
                throw new TypingException(erros);
            boissonRepo.Add(boisson);
        }
        public void DeleteBoisson(Boisson boisson)
        {
            boissonRepo.Remove(boisson);
        }
        public IEnumerable<Boisson> GetBy(Func<Boisson, bool> predicate)
        {
            return boissonRepo.Find(predicate);
        }
        public IEnumerable<Boisson> GetById(int id)
        {
            return boissonRepo.Find(x => x.Id == id);
        }
        private List<KeyValuePair<string, string>> validate(Boisson boisson)
        {
            List<KeyValuePair<string, string>> erros = new List<KeyValuePair<string, string>>();

            return erros;
        }

        public IEnumerable<Boisson> GetAllBoisson()
        {
            return boissonRepo.Find();
        }
        public void EditBoisson(Boisson oldBoisson, Boisson newBoisson)
        {
            boissonRepo.Set(oldBoisson, newBoisson);
        }
    }
}
