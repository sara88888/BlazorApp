namespace BlazorApp.Entities
{
    public class Product
    {
        public int ID { get; set; }
        public string ImgPath { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; } = 0.0m;
    }
}
