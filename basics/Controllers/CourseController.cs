using basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace basics.Controllers
{


    //course
    public class CourseController : Controller
    {
        //course
        //course/index
        public IActionResult Index()

        {
            //Course Modelinden obje tanımlama
            var course = new Course();
            course.Id = 1;
            course.Title = "Aspnet Core Kursu";
            course.Description = "Güzel bir kurs";
            course.Image = "1.jpg";
            return View(course);
        }

        public IActionResult Details()

        {
            var course = new Course();
            course.Id = 1;
            course.Title = "Aspnet Core Kursu";
            course.Description = "Güzel bir kurs";
            course.Image = "1.jpg";
            return View(course);
        }

        //course/list
        public IActionResult List()
        {
            return View("CourseList", Repository.Courses);
        }
    }
}
