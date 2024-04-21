using Microsoft.EntityFrameworkCore;
using ORMEntitiyFramework.Entities;

namespace ORMEntitiyFramework.DAL
{
    internal class DataContext:DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Ingridient> Ingridients { get; set;}
        public DbSet<Order>Orders { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=WIN-PJER2FH7OJN;Database=CoffeeShop;Integrated Security=True;TrustServerCertificate=True;Trusted_Connection=True;");
        }
    }
}
