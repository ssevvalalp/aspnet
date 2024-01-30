using FormsApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics;

namespace FormsApp.Controllers
{
    public class HomeController : Controller
    {
       
        public HomeController()
        {
            
        }

        [HttpGet]
        public IActionResult Index(string searchString, string category)
        {
            var products = Repository.Products;

            //get products
            if (!String.IsNullOrEmpty(searchString))
            {
                ViewBag.SearchString = searchString;
                products = products.Where(p => p.Name.ToLower().Contains(searchString)).ToList();
                
            }

            //get categories
            if (!String.IsNullOrEmpty(category) && category != "0")
            {
                products = products.Where(p => p.CategoryId == int.Parse(category)).ToList();
            }

            //ViewBag.Categories = new SelectList(Repository.Categories, "CategoryId", "Name", category);

            var model = new ProductViewModel {
                Products = products,
                Categories = Repository.Categories,
                SelectedCategory = category
            };
            return View(model);

        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Categories = Repository.Categories;
            return View();

        }

        [HttpPost]
        public IActionResult Create(Product model)
        {
            return View();

        }

    }
}
