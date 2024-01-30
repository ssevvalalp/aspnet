namespace FormsApp.Models
{
    public class ProductViewModel
    {
        //product list
        public List<Product> Products { get; set; } = null!;

        //category list
        public List<Category> Categories { get; set; } = null!;

        //ViewBag Parameters

        public string? SelectedCategory { get; set; }
    }


}
