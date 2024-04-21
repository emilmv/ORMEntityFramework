using ORMEntitiyFramework.DAL;
using ORMEntitiyFramework.Entities;

namespace ORMEntitiyFramework.Services
{
    public class CustomerService
    {
        public List<Customer> Get()
        {
            using var dc = new DataContext();
            return dc.Customers.ToList();
        }
        public Customer? GetById(int id)
        {
            using var dc = new DataContext();
            return dc.Customers.FirstOrDefault(c => c.ID == id);
        }
        public void Create(Customer customer)
        {
            using var dc = new DataContext();
            var alreadyExists = dc.Customers.FirstOrDefault(c => c.CustomerName.ToLower() == customer.CustomerName.ToLower());
            if (alreadyExists != null) return;
            dc.Customers.Add(customer);
            dc.SaveChanges();
        }
        public void Update(int id, string newName)
        {
            using var dc = new DataContext();
            var customer = dc.Customers.FirstOrDefault(c => c.ID == id);
            if (customer != null) customer.CustomerName = newName;
            dc.SaveChanges();
        }
        public void Delete(int id)
        {
            using var dc = new DataContext();
            var customer = dc.Customers.FirstOrDefault(c => c.ID == id);
            if (customer != null) dc.Remove(customer);
            dc.SaveChanges();
        }
    }
}
