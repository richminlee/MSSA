namespace Lab9B.Models
{
    public class Product
    {
        public Product(bool stock = true)
        {   
            InStock = stock;
        }
        public string Name { get; set; }
        public string Category {get; set;} = "Watersports";
        public decimal? Price { get; set; }
        public Product Related {get; set;}
        public bool InStock { get; }
        public static Product[] GetProducts()
        {
            Product kayak = new Product();
            kayak.Name = "Kayak";
            kayak.Category = "Water Craft";
            kayak.Price = 275M;
            Product lifejacket  = new Product(false);
            lifejacket.Name = "Lifejacket";
            lifejacket.Price = 48.95M;
            kayak.Related = lifejacket;
            return new Product[] {kayak, lifejacket, null};
        }
    }
}