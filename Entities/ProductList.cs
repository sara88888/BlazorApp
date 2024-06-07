namespace BlazorApp.Entities
{
    public class ProductList
    {
        private List<Product> _products;
        public List<Product> Products { get { return _products; } }

        public ProductList()
        {
            _products = new List<Product>();

            _products.Add(new Product { ID = 1, ImgPath = "images/Img1.png", Name = "Foundation", Price = 12.50m });
            _products.Add(new Product { ID = 2, ImgPath = "images/Img2.png", Name = "Lipstick", Price = 7.99m });
            _products.Add(new Product { ID = 3, ImgPath = "images/Img3.png", Name = "Parfum", Price = 48.20m });
            _products.Add(new Product { ID = 4, ImgPath = "images/Img4.png", Name = "Accessories", Price = 4.75m });
            _products.Add(new Product { ID = 5, ImgPath = "images/Img5.png", Name = "Eye shadows", Price = 15.99m });
            _products.Add(new Product { ID = 6, ImgPath = "images/Img6.png", Name = "Moisturizer", Price = 21.15m });
            _products.Add(new Product { ID = 7, ImgPath = "images/Img7.png", Name = "Bottle set", Price = 3.15m });
            _products.Add(new Product { ID = 8, ImgPath = "images/Img8.png", Name = "Olive care", Price = 20.99m });
            _products.Add(new Product { ID = 9, ImgPath = "images/Img9.png", Name = "Detox cream", Price = 20.99m });
            _products.Add(new Product { ID = 10, ImgPath = "images/Img10.png", Name = "Scarlet", Price = 11.15m });
            _products.Add(new Product { ID = 11, ImgPath = "images/Img11.png", Name = "Beauty set", Price = 31.15m });
            _products.Add(new Product { ID = 12, ImgPath = "images/Img12.png", Name = "Earth vibes", Price = 25.50m });
            _products.Add(new Product { ID = 13, ImgPath = "images/Img13.png", Name = "Day & Night", Price = 39.99m });
            _products.Add(new Product { ID = 14, ImgPath = "images/Img14.png", Name = "Lipstick set", Price = 19.50m });
        }
    }
}
