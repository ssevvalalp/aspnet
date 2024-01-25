using basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace basics.Controllers
{
    //localhost -->home/index
    //localhost/home  -->home/index
    //localhost/home/index -->home/index

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
            return View(course);
        }

        //course/index/list
        public IActionResult List()
        {
            return View("CourseList");
        }
    }
}
