using EasyGest.BO;
using EasyGest.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyGest.BLL
{
    public class PlatBLO
    {
        PlatDAO platRepo;
        public PlatBLO(string dbfolder)
        {
            platRepo = new PlatDAO(dbfolder);
        }

        public void Save(Plat plat)
        {
            if (plat == null)
                throw new ArgumentNullException(nameof(plat));
            var erros = validate(plat);
            if (erros != null && erros.Count > 0)
                throw new TypingException(erros);
            platRepo.Add(plat);
        }
        public void DeletePlat(Plat plat)
        {
            platRepo.Remove(plat);
        }
        public IEnumerable<Plat> GetBy(Func<Plat, bool> predicate)
        {
            return platRepo.Find(predicate);
        }
        public IEnumerable<Plat> GetById(int id)
        {
            return platRepo.Find(x => x.Id == id);
        }
        private List<KeyValuePair<string, string>> validate(Plat plat)
        {
            List<KeyValuePair<string, string>> erros = new List<KeyValuePair<string, string>>();

            return erros;
        }

        public IEnumerable<Plat> GetAllPlat()
        {
            return platRepo.Find();
        }
        public void EditPlat(Plat oldPlat, Plat newPlat)
        {
            platRepo.Set(oldPlat, newPlat);
        }
    }
}
