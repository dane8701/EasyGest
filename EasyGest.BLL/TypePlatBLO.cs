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
    public class TypePlatBLO
    {
        TypePlatDAO typePlatRepo;
        public TypePlatBLO(string dbfolder)
        {
            typePlatRepo = new TypePlatDAO(dbfolder);
        }

        public void Save(TypePlat typePlat)
        {
            if (typePlat == null)
                throw new ArgumentNullException(nameof(typePlat));
            var erros = validate(typePlat);
            if (erros != null && erros.Count > 0)
                throw new TypingException(erros);
            typePlatRepo.Add(typePlat);
        }
        public void DeleteTypePlat(TypePlat typePlat)
        {
            typePlatRepo.Remove(typePlat);
        }
        public IEnumerable<TypePlat> GetBy(Func<TypePlat, bool> predicate)
        {
            return typePlatRepo.Find(predicate);
        }
        public IEnumerable<TypePlat> GetById(int id)
        {
            return typePlatRepo.Find(x => x.Id == id);
        }
        private List<KeyValuePair<string, string>> validate(TypePlat typePlat)
        {
            List<KeyValuePair<string, string>> erros = new List<KeyValuePair<string, string>>();

            return erros;
        }

        public IEnumerable<TypePlat> GetAllTypePlat()
        {
            return typePlatRepo.Find();
        }
        public void EditTypePlat(TypePlat oldTypePlat, TypePlat newTypePlat)
        {
            typePlatRepo.Set(oldTypePlat, newTypePlat);
        }
    }
}
