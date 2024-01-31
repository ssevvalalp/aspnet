using FormsApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics;
using System.IO;

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
                products = products.Where(p => p.Name!.ToLower().Contains(searchString)).ToList();
                //modelde nullable alan olarak tanımladım ama, ! ile böyle kullanım yapmayacağımı garantiliyorum

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
            ViewBag.Categories = new SelectList(Repository.Categories, "CategoryId", "Name");
            return View();

        }

        [HttpPost]
        public async Task<IActionResult> Create(Product model, IFormFile imageFile)
        //public IActionResult Create(string Name, decimal Price, int CategoryId)
        //public IActionResult Create([Bind("Name", "Price", "CategoryId")]Product model)
        {


            var allowedExtensions = new[] { ".jpg", ".jpeg", ".png" };
            var extension = Path.GetExtension(imageFile.FileName);// abc.jpg ->.jpg
            var randomFileName = string.Format($"{Guid.NewGuid().ToString()}{extension}"); // abc + .jpg -> abc.jpg 
            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img", randomFileName);

            if (imageFile != null)
            {
                if (!allowedExtensions.Contains(extension))
                {
                    ModelState.AddModelError("", "Geçerli bir görsel seçiniz");
                }
            }

            if (ModelState.IsValid)
            {
                //uploding the file
                if (imageFile != null)
                {

                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await imageFile.CopyToAsync(stream);
                    }
                }


                model.Image = randomFileName;

                model.ProductId = Repository.Products.Count + 1;
                Repository.CreatedProduct(model);
                return RedirectToAction("Index");


            }
            ViewBag.Categories = new SelectList(Repository.Categories, "CategoryId", "Name");

            return View(model);
        }

        [HttpGet]
        public IActionResult Edit(int? id) //url içinden id parametresini aldık ve edit formuna yönlendirdik.
        {
            if(id == null)
            {
                return NotFound();
            }

            var entity = Repository.Products.FirstOrDefault(p => p.ProductId == id);
            if (entity == null)
            {
                return NotFound();
            }

            ViewBag.Categories = new SelectList(Repository.Categories, "CategoryId", "Name");
            return View(entity);
        }

        [HttpPost]

        public async Task<IActionResult> Edit(int id, Product model, IFormFile? imageFile)
        {

            if(id != model.ProductId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {

                if (imageFile != null)
                {
                    var extension = Path.GetExtension(imageFile.FileName);// abc.jpg ->.jpg
                    var randomFileName = string.Format($"{Guid.NewGuid().ToString()}{extension}"); // abc + .jpg -> abc.jpg 
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img", randomFileName);


                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await imageFile.CopyToAsync(stream);
                    }

                    model.Image = randomFileName;
                }

                Repository.EditProduct(model);
                return RedirectToAction("Index");

            }

            ViewBag.Categories = new SelectList(Repository.Categories, "CategoryId", "Name");
            return View(model);
        }


    }


}
