using ORMEntitiyFramework.DAL;
using ORMEntitiyFramework.Entities;

namespace ORMEntitiyFramework.Services
{
    public class IngridientService
    {
        public List<Ingridient> Get()
        {
            using var dc = new DataContext();
            return dc.Ingridients.ToList();
        }
        public Ingridient? GetById(int id)
        {
            using var dc = new DataContext();
            return dc.Ingridients.FirstOrDefault(i => i.ID == id);
        }
        public void Create(Ingridient ingridient)
        {
            using var dc = new DataContext();
            var alreadyExists = dc.Ingridients.FirstOrDefault(p => p.IngridientName.ToLower() == ingridient.IngridientName.ToLower());
            if (alreadyExists != null) return;
            dc.Ingridients.Add(ingridient);
            dc.SaveChanges();
        }
        public void Update(int id, string newName)
        {
            using var dc = new DataContext();
            var ingridient = dc.Ingridients.FirstOrDefault(i => i.ID == id);
            if (ingridient != null) ingridient.IngridientName = newName;
            dc.SaveChanges();
        }
        public void Delete(int id)
        {
            using var dc = new DataContext();
            var ingridient = dc.Ingridients.FirstOrDefault(i => i.ID == id);
            if (ingridient != null) dc.Remove(ingridient);
            dc.SaveChanges();
        }
    }
}
