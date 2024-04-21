using ORMEntitiyFramework.DAL;
using ORMEntitiyFramework.Entities;

namespace ORMEntitiyFramework.Services
{
    public class OrderService
    {
        public List<Order> Get()
        {
            using var dc = new DataContext();
            return dc.Orders.ToList();
        }
        public Order? GetById(int id)
        {
            using var dc = new DataContext();
            return dc.Orders.FirstOrDefault(o=>o.ID==id);
        }
        public void Create(Order order)
        {
            using var dc = new DataContext();
            var alreadyExists = dc.Orders.FirstOrDefault(p => p.ID== order.ID);
            if (alreadyExists != null) return;
            dc.Orders.Add(order);
            dc.SaveChanges();
        }
        public void Delete(int id)
        {
            using var dc = new DataContext();
            var order = dc.Orders.FirstOrDefault(o =>o.ID == id);
            if (order != null) dc.Remove(order);
            dc.SaveChanges();
        }
    }
}
