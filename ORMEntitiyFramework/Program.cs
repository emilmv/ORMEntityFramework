using ORMEntitiyFramework.DAL;
using ORMEntitiyFramework.Services;

namespace ORMEntitiyFramework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using DataContext dc = new();

            //Adding Coffee Products to Table

            dc.Products.AddRange(
                new() { ProductName = "Iced Latte", ProductPrice = 12.50m, IsServedHot = false },
                new() { ProductName = "Latte", ProductPrice = 12.50m, IsServedHot = true },
                new() { ProductName = "Espresso", ProductPrice = 3.50m, IsServedHot = true },
                new() { ProductName = "Americano", ProductPrice = 4.90m, IsServedHot = true },
                new() { ProductName = "Glisse", ProductPrice = 7.50m, IsServedHot = false });
            dc.SaveChanges();

            //Adding Coffee Products to Table with Method

            ProductService ps = new();
            ps.Create(new() { ProductName = "Raf Coffee", ProductPrice = 6.50m, IsServedHot = true });
            ps.Create(new() { ProductName = "Hot Chocolate", ProductPrice = 7.90m, IsServedHot = true });
            ps.Create(new() { ProductName = "Mocha", ProductPrice = 7.50m, IsServedHot = true });
            ps.Create(new() { ProductName = "Cappuccino", ProductPrice = 5.59m, IsServedHot = true });
            ps.Create(new() { ProductName = "Espresso Macchiato", ProductPrice = 3.50m, IsServedHot = true });








        }
    }
}
