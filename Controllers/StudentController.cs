using Microsoft.AspNetCore.Mvc;
using  DemoMVC.Models;
using DemoMVC.Controllers;

namespace DemoMVC.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
            {
                return View();
            }
        
        [HttpPost]
        public IActionResult Index(Student std)
        {
        
        ViewBag.mess = std.StudentID + "-" + std.StudentName + "-" + std.StudentAge;
            return View();
        }
    }
}