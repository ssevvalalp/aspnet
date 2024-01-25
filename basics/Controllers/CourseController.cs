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
            return View();
        }

        //course/index/list
        public IActionResult List()
        {
            return View("CourseList");
        }
    }
}
