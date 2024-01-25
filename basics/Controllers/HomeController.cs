using basics.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Diagnostics;

namespace basics.Controllers
{
    public class HomeController : Controller
    {
      

        public string Index()
        {
            return "home/index";
        }

        public string Contact()
        {
            return "home/Contact";
        }

    }
}
