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
            var courses = new List<Course>()
            {
                new Course(){Id = 1, Title = "Aspnet Kursu", Description = "güzel bir kurs", Image ="1.jpg"},
                new Course(){Id = 2, Title = "Php Kursu", Description = "güzel bir kurs", Image = "2.jpg"},
                new Course(){Id = 3, Title = "Django Kursu", Description = "güzel bir kurs", Image = "3.jpg"}
              
            };
            return View("CourseList", courses);
        }
    }
}
