using basics_FilmsApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace basics_FilmsApp.Controllers
{
    public class HomeController : Controller
    {
      

        public IActionResult Index()
        {
            return View(Repository.Films);
        }

       

    }
}
