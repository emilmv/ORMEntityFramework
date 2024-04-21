using ORMEntitiyFramework.DAL;
using ORMEntitiyFramework.Entities;

namespace ORMEntitiyFramework.Services
{
    public class ProductService
    {
        public List<Product> Get()
        {
            using var dc = new DataContext();
            return dc.Products.ToList();
        }
        public Product? GetById(int id)
        {
            using var dc = new DataContext();
            return dc.Products.FirstOrDefault(p=>p.ID== id);
        }
        public void Create(Product product)
        {
            using var dc = new DataContext();
            var alreadyExists = dc.Products.FirstOrDefault(p => p.ProductName.ToLower() == product.ProductName.ToLower());
            if (alreadyExists != null) return;
            dc.Products.Add(product);
            dc.SaveChanges();
        }
        public void Update(int id, decimal newPrice)
        {
            using var dc = new DataContext();
            var product = dc.Products.FirstOrDefault(p=>p.ID==id);
            if (product != null) product.ProductPrice = newPrice;
            dc.SaveChanges();
        }
        public void Delete(int id)
        {
            using var dc = new DataContext();
            var product = dc.Products.FirstOrDefault(p=>p.ID==id);
            if (product != null) dc.Remove(product);
            dc.SaveChanges();
        }
    }
}
