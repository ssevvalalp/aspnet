namespace FormsApp.Models
{
    public class Repository
    {
        private static readonly List<Product> _products = new List<Product>();
        private static readonly List<Category> _categories = new List<Category>();

        //constructor
        static Repository()
        {

        }



        public static List<Product> Products
        { 
        
            get {
                return _products; 
            }
        }

        public static List<Category> Categories { get
            {
                return _categories;
            } }
            
            
    }
}
