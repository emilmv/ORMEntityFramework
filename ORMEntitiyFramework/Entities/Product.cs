namespace ORMEntitiyFramework.Entities
{
    public class Product
    {
        public int ID { get; set; }
        public string? ProductName { get; set; }
        public bool IsServedHot { get; set; }
        public decimal ProductPrice { get; set; }
    }
}
