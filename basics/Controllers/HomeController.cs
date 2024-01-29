using basics.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Diagnostics;

namespace basics.Controllers
{
    public class HomeController : Controller
    {
        //localhost -->home/index
        //localhost/home  -->home/index
        //localhost/home/index -->home/index

        public IActionResult Index()
        {
            return View(Repository.Courses);
        }

        public IActionResult Contact()
        {
            return View();
        }

    }
}
