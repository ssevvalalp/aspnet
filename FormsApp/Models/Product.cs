using System.ComponentModel.DataAnnotations;

namespace FormsApp.Models
{
    public class Product
    {
        //@Html.DisplayNameFor
        [Display(Name = "Product Id")]
        public int ProductId { get; set; }

        [Display(Name = "Name")]
        [Required]
        public string Name { get; set; } = string.Empty;

        [Display(Name = "Price")]
       
        public decimal Price { get; set; }

        [Display(Name = "Image")]
        public string? Image { get; set; }

        public bool IsActive { get; set; }

        [Display(Name = "Category")]
        public int CategoryId { get; set; } //foreign key
    }
}
