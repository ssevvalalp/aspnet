using System.ComponentModel.DataAnnotations;

namespace FormsApp.Models
{
    public class Product
    {
        //@Html.DisplayNameFor
        [Display(Name = "Product Id")]
        public int ProductId { get; set; }

        public string Name { get; set; } = string.Empty;

        [Display(Name = "Price")]
        public decimal Price { get; set; }

        public string? Image { get; set; }

        public bool IsActive { get; set; }

        public int CategoryId { get; set; } //foreign key
    }
}
