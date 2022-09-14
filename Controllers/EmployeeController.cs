using Microsoft.AspNetCore.Mvc;
using  DemoMVC.Models;
using DemoMVC.Controllers;

namespace DemoMVC.Controllers
{
    public class EmployeeController : Controller
    {
       public ActionResult Index()
        {
            //khoi tao list Employee
            List<Employee> stdList= new List<Employee>
            { 
                new Employee { EmployeeID = 1, EmployeeName = "Nguyen Van An", EmployeeAge = 25 },
                new Employee { EmployeeID = 2, EmployeeName = "Nguyen Thi Ha ", EmployeeAge = 30 },
                new Employee { EmployeeID = 3, EmployeeName = "Nguyen Van Minh", EmployeeAge = 23 },
                new Employee { EmployeeID = 4, EmployeeName = "Nguyen Thi Thu", EmployeeAge = 28 },
               
            };
            ViewData["Employees"] = stdList;
            return View();
        }
    }
}