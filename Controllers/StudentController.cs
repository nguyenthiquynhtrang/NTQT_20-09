using Microsoft.AspNetCore.Mvc;
using  DemoMVC.Models;
using DemoMVC.Controllers;

namespace DemoMVC.Controllers
{
    public class StudentController : Controller
    {
       public ActionResult Index()
        {
            //khoi tao list student
            List<Student> stdList= new List<Student>
            { 
                new Student { StudentID = 1, StudentName = "Nguyen Van A", StudentAge = 18 },
                new Student { StudentID = 2, StudentName = "Nguyen Van B", StudentAge = 18 },
                new Student { StudentID = 3, StudentName = "Nguyen Van C", StudentAge = 18 },
                new Student { StudentID = 4, StudentName = "Nguyen Van D", StudentAge = 18 },
                new Student { StudentID = 5, StudentName = "Nguyen Van E", StudentAge = 18 },
                new Student { StudentID = 6, StudentName = "Nguyen Van F", StudentAge = 18 },
                new Student { StudentID = 7, StudentName = "Nguyen Van G", StudentAge = 18 },
            };
            ViewData["Students"] = stdList;
            return View();
        }
    }
}