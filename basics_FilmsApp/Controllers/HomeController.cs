using basics_FilmsApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace basics_FilmsApp.Controllers
{
    public class HomeController : Controller
    {
       

        public HomeController()
        {
            
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

    }
}
