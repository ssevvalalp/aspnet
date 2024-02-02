namespace FormsApp.Models
{
    public class Repository
    {
        private static readonly List<Product> _products = new List<Product>();
        private static readonly List<Category> _categories = new List<Category>();

        //constructor
        static Repository()
        {

            _categories.Add(new Category { CategoryId = 1, Name = "Telefon" });
            _categories.Add(new Category { CategoryId = 2, Name = "Bilgisayar" });

            _products.Add(new Product { ProductId = 1, Name = "Iphone 14 ", Price = 40000, IsActive = true, Image = "1.jpg", CategoryId = 1 });
            _products.Add(new Product { ProductId = 2, Name = "Iphone 15 ", Price = 50000, IsActive = true, Image = "2.jpg", CategoryId = 1 });
            _products.Add(new Product { ProductId = 3, Name = "Iphone 16 ", Price = 60000, IsActive = true, Image = "3.jpg", CategoryId = 1 });
            _products.Add(new Product { ProductId = 4, Name = "Iphone 17 ", Price = 70000, IsActive = true, Image = "4.jpg", CategoryId = 1 });


            _products.Add(new Product { ProductId = 5, Name = "Macbook Air ", Price = 80000, IsActive = true, Image = "5.jpg", CategoryId = 2 });
            _products.Add(new Product { ProductId = 6, Name = "Macbook Pro ", Price = 90000, IsActive = true, Image = "6.jpg", CategoryId = 2 });
        }


        //Adding the data received via PostForm to the Repository

        public static void CreatedProduct(Product newProduct)
        {
            _products.Add(newProduct);

        }

        public static void EditProduct (Product updatedProduct)
        {
            var entitiy = _products.FirstOrDefault(p => p.ProductId == updatedProduct.ProductId);

            if(entitiy != null)
            {
                entitiy.Name = updatedProduct.Name;
                entitiy.Price = updatedProduct.Price;
                entitiy.Image = updatedProduct.Image;
                entitiy.IsActive = updatedProduct.IsActive;
                entitiy.CategoryId = updatedProduct.CategoryId;
                
            }
        }

        public static void DeleteProduct(Product deletedProduct)
        {
            var entitiy = _products.FirstOrDefault(p => p.ProductId == deletedProduct.ProductId);

            if (entitiy != null)
            {
                _products.Remove(entitiy);
            }
        }


        public static List<Product> Products
        { 
        
            get {
                return _products; 
            }
        }

        public static List<Category> Categories 
        {
            get {
                return _categories;
            } 
        }
            
            
    }
}
