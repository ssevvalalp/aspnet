using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace FormsApp.Models
{
    //[Bind("Name", "Price", "CategoryId")]
    public class Product
    {
        //@Html.DisplayNameFor
        [Display(Name = "Product Id")]
        public int ProductId { get; set; }

        [Display(Name = "Name")]
        [Required (ErrorMessage ="Zorunlu alan")] 
        [StringLength(100,ErrorMessage ="{0}, Length must be between {2} and {1}", MinimumLength = 3)] //length range
        public string? Name { get; set; }

        [Range(0, 100000)]
        [Display(Name = "Price")]

        [Required]
        public decimal? Price { get; set; }

        //[BindNever]
        
        [Display(Name = "Image")]
        public string? Image { get; set; } = string.Empty;

        public bool IsActive { get; set; }

        [Required]
        [Display(Name = "Category")]
        public int? CategoryId { get; set; } //foreign key
    }
}
