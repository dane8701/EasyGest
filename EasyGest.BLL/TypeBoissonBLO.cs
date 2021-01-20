using EasyGest.BO;
using EasyGest.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyGest.BLL
{
    public class TypeBoissonBLO
    {
        TypeBoissonDAO typeBoissonRepo;
        public TypeBoissonBLO(string dbfolder)
        {
            typeBoissonRepo = new TypeBoissonDAO(dbfolder);
        }

        public void Save(TypeBoisson typeBoisson)
        {
            if (typeBoisson == null)
                throw new ArgumentNullException(nameof(typeBoisson));
            var erros = validate(typeBoisson);
            if (erros != null && erros.Count > 0)
                throw new TypingException(erros);
            typeBoissonRepo.Add(typeBoisson);
        }
        public void DeleteTypeBoisson(TypeBoisson typeboisson)
        {
            typeBoissonRepo.Remove(typeboisson);
        }
        public IEnumerable<TypeBoisson> GetBy(Func<TypeBoisson, bool> predicate)
        {
            return typeBoissonRepo.Find(predicate);
        }
        public IEnumerable<TypeBoisson> GetById(int id)
        {
            return typeBoissonRepo.Find(x => x.Id == id);
        }
        private List<KeyValuePair<string, string>> validate(TypeBoisson typeBoisson)
        {
            List<KeyValuePair<string, string>> erros = new List<KeyValuePair<string, string>>();

            return erros;
        }

        public IEnumerable<TypeBoisson> GetAllTypeBoisson()
        {
            return typeBoissonRepo.Find();
        }
        public void EditTypeBoisson(TypeBoisson oldTypeBoisson, TypeBoisson newTypeBoisson)
        {
            typeBoissonRepo.Set(oldTypeBoisson, newTypeBoisson);
        }
    }
}
