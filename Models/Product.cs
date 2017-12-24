namespace LanguageFeatures.Models
{
    public class Product
    {
        public string Name { get; set; }
        public decimal? Price { get; set; }

        public static Product[] GetProducts()
        {
          var kayak = new Product {
            Name = "Kayak", Price = 275M
          };
          var lifejacket = new Product {
            Name = "LifeJacket", Price = 48.95M
          };
          return new Product[] { kayak, lifejacket, null };
        }
    }
}