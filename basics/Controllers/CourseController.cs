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
        public string Index()
        {
            return "course/index";
        }

        public string List()
        {
            return "course/list";
        }
    }
}
