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
    public class TypeTableBLO
    {
        TypeTableDAO typeTableRepo;
        public TypeTableBLO(string dbfolder)
        {
            typeTableRepo = new TypeTableDAO(dbfolder);
        }

        public void Save(TypeTable typeTable)
        {
            if (typeTable == null)
                throw new ArgumentNullException(nameof(typeTable));
            var erros = validate(typeTable);
            if (erros != null && erros.Count > 0)
                throw new TypingException(erros);
            typeTableRepo.Add(typeTable);
        }
        public void DeleteTypeTable(TypeTable typeTable)
        {
            typeTableRepo.Remove(typeTable);
        }
        public IEnumerable<TypeTable> GetBy(Func<TypeTable, bool> predicate)
        {
            return typeTableRepo.Find(predicate);
        }
        public IEnumerable<TypeTable> GetById(int id)
        {
            return typeTableRepo.Find(x => x.Id == id);
        }
        private List<KeyValuePair<string, string>> validate(TypeTable typeTable)
        {
            List<KeyValuePair<string, string>> erros = new List<KeyValuePair<string, string>>();

            return erros;
        }

        public IEnumerable<TypeTable> GetAllTypeTable()
        {
            return typeTableRepo.Find();
        }
        public void EditTypeTable(TypeTable oldTypeTable, TypeTable newTypeTable)
        {
            typeTableRepo.Set(oldTypeTable, newTypeTable);
        }
    }
}